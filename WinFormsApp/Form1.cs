using CommonClassLib.Structures;
using FileParserLib.ObjParser;
using PolygonFillerLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Triangle> triangles;
        private Bitmap drawArea;
        private Bitmap texture = null;
        private Bitmap normalMap;

        private Color lightColor = Color.White;
        private Color? objectColor = Color.DeepPink;
        private Vector lightCoordinates;
        private PolygonFiller polygonFiller;

        private Timer timer;
        private float r = 0;
        private float theta = 0;

        private List<Polygon> clouds;
        private List<Polygon> shadows;
        private PolygonFiller cloudFiller;
        private PolygonFiller shadowFiller;

        public Form1()
        {
            InitializeComponent();

            FilenameLabel.Text = "../../../Resources/Obj/Sphere.obj";

            InitDrawAreas();

            InitFile();

            GenerateClouds();

            cloudFiller = new CloudFiller(drawArea, new Bitmap("../../../Resources/clouds.png"));
            shadowFiller = new ShadowFiller(drawArea);

            UpdateFillingAlgorithm(null, null);

            InitTimer(Timer_Tick, 1);
        }

        private void InitFile()
        {
            triangles = ObjParser.ParseObjToTriangleCollection(FilenameLabel.Text);

            if (triangles is null)
                MessageBox.Show("Error", "Cannot open file specified. Selected file doesn't exist or you cannot access it.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                FitTrianglesToDrawArea();
        }

        private void InitTimer(EventHandler timerTick, int interval)
        {
            timer = new Timer();
            timer.Tick += timerTick;
            timer.Interval = interval;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lightCoordinates.X = drawArea.Width / 2 + (float)(r * Math.Cos(theta));
            lightCoordinates.Y = drawArea.Height / 2 + (float)(r * Math.Sin(theta));

            theta += 0.05f;
            r += 0.5f + (Math.Max(drawArea.Width, 2 * r) / 2 - r) / 50;

            if (CloudsCheckBox.Checked)
            {
                shadows.Clear();
                foreach(var cloud in clouds)
                {
                    MoveCloud(cloud);
                    shadows.Add(CalcShadow(cloud));
                }

            }

            Redraw();
        }

        private Polygon CreateCloud(int x, int y)
        {
            int z = Z_slider.Value - 500;
            return new Polygon()
            {
                Vertices = new List<Vertex>()
                {
                    //new Vertex(new Vector(x - 100, y, Z_slider.Value - 500), null),
                    //new Vertex(new Vector(x, y - 100, Z_slider.Value - 500), null),
                    //new Vertex(new Vector(x + 100, y - 100, Z_slider.Value - 500), null),
                    //new Vertex(new Vector(x + 50, y - 50, Z_slider.Value - 500), null),
                    //new Vertex(new Vector(x - 50, y - 10, Z_slider.Value - 500), null)
                    new Vertex(new Vector(x - 50, y - 25, z), null),
                    new Vertex(new Vector(x - 12, y - 75, z), null),
                    new Vertex(new Vector(x + 25, y - 50, z), null),
                    new Vertex(new Vector(x + 75, y - 50, z), null),
                    new Vertex(new Vector(x + 100, y + 12, z), null),
                    new Vertex(new Vector(x + 50, y + 45, z), null),
                    new Vertex(new Vector(x - 12, y + 12, z), null),
                    new Vertex(new Vector(x - 60, y + 10, z), null)
                }
            };
        }

        private void MoveCloud(Polygon cloud)
        {
            foreach (var v in cloud.Vertices)
                v.Coordinates.X += 5;

            float min = cloud.Vertices.Min(v => v.Coordinates.X);
            if (min > drawArea.Width)
            {
                float max = cloud.Vertices.Max(v => v.Coordinates.X);
                float change = max - min;

                foreach (var v in cloud.Vertices)
                    v.Coordinates.X -= drawArea.Width + change;
            }
        }

        private Polygon CalcShadow(Polygon cloud)
        {
            var ret =  new Polygon()
            {
                Vertices = new List<Vertex>()
            };
            foreach (var v in cloud.Vertices)
                ret.Vertices.Add(
                    new Vertex(
                        new Vector(
                            lightCoordinates.X + (v.Coordinates.X - lightCoordinates.X) * v.Coordinates.Z / (lightCoordinates.Z - v.Coordinates.Z),
                            lightCoordinates.Y + (v.Coordinates.Y - lightCoordinates.Y) * v.Coordinates.Z / (lightCoordinates.Z - v.Coordinates.Z),
                            0
                        ), null));
            return ret;
        }

        private void GenerateClouds()
        {
            clouds = new List<Polygon>(12);
            for (int i = 0; i < 4; i++)
                clouds.Add(CreateCloud(i * drawArea.Width / 4, i * drawArea.Height / 4));
            clouds.Add(CreateCloud(drawArea.Width / 4, 3 * drawArea.Height / 4));
            clouds.Add(CreateCloud(3 * drawArea.Width / 4, drawArea.Height / 4));
            for (int i = 0; i < 4; i++)
                clouds.Add(CreateCloud(-drawArea.Width + i * drawArea.Width / 4, i * drawArea.Height / 4));
            clouds.Add(CreateCloud(-drawArea.Width + drawArea.Width / 4, 3 * drawArea.Height / 4));
            clouds.Add(CreateCloud(-drawArea.Width + 3 * drawArea.Width / 4, drawArea.Height / 4));
            shadows = new List<Polygon>(12);
            foreach (var cloud in clouds)
                shadows.Add(CalcShadow(cloud));
        }

        private void InitDrawAreas()
        {
            drawArea = new Bitmap(600, 800);
            Canvas.Image = drawArea;

            FillingSelectionCanvas.Image = new Bitmap(FillingSelectionCanvas.Size.Width, FillingSelectionCanvas.Size.Height);
            using var g1 = Graphics.FromImage(FillingSelectionCanvas.Image);
            g1.Clear(objectColor.Value);

            LightSelectionCanvas.Image = new Bitmap(LightSelectionCanvas.Width, LightSelectionCanvas.Height);
            using var g2 = Graphics.FromImage(LightSelectionCanvas.Image);
            g2.Clear(lightColor);
        }

        private void FitTrianglesToDrawArea()
        {
            var coordinates = triangles.SelectMany(t => t.Vertices).Select(v => v.Coordinates).Distinct();

            var minX = coordinates.Min(v => v.X);
            var minY = coordinates.Min(v => v.Y);

            foreach (var coor in coordinates)
            {
                coor.X -= minX;
                coor.Y -= minY;
            }

            var maxX = coordinates.Max(v => v.X);
            var maxY = coordinates.Max(v => v.Y);

            float factorX = (drawArea.Width - 20) / maxX;
            float factorY = (drawArea.Height - 20) / maxY;

            var factor = Math.Min(factorX, factorY);

            foreach (var coor in coordinates)
            {
                coor.X *= factor;
                coor.Y *= factor;
                coor.Z *= factor;
            }

            var deltaX = (drawArea.Width - maxX * factor) / 2;
            var deltaY = (drawArea.Height - maxY * factor) / 2;

            foreach (var coor in coordinates)
            {
                coor.X += deltaX;
                coor.Y += deltaY;
            }

            var z = coordinates.Max(c => c.Z);
            Z_slider.Minimum = (int)z + 600;
            Z_slider.Value = (int)z + 1000;

            Z_label.Text = Z_slider.Value.ToString();

            lightCoordinates = new Vector(drawArea.Width / 2, drawArea.Height / 2, Z_slider.Value);
        }

        private void Redraw()
        {
            using Graphics g = Graphics.FromImage(drawArea);

            g.Clear(Color.White);

            lightCoordinates.Z = (float)Z_slider.Value;

            foreach (var t in triangles)
            {
                polygonFiller.FillPolygon(t);

                if (EdgesCheckbox.Checked)
                    t.DrawShape(drawArea);
            }

            if (CloudsCheckBox.Checked)
            {
                foreach(var shadow in shadows)
                    shadowFiller.FillPolygon(shadow);
                foreach(var cloud in clouds)
                    cloudFiller.FillPolygon(cloud);
            }


            if (LightCheckBox.Checked)
                g.FillEllipse(Brushes.Yellow, lightCoordinates.X - 10, lightCoordinates.Y - 10, 20, 20);

            Canvas.Invalidate();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                timer.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            r = 0;
            theta = 0;
            Redraw();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!(texture is null))
                {
                    texture.Dispose();
                    texture = null;
                }

                objectColor = colorDialog.Color;

                if (!(FillingSelectionCanvas.Image is null))
                {
                    FillingSelectionCanvas.Image.Dispose();
                    FillingSelectionCanvas.Image = null;
                }

                FillingSelectionCanvas.Image = new Bitmap(FillingSelectionCanvas.Width, FillingSelectionCanvas.Height);

                using var g = Graphics.FromImage(FillingSelectionCanvas.Image);
                g.Clear(objectColor.Value);

                UpdateFillingAlgorithm(sender, e);
            }
        }

        private void TextureButton_Click(object sender, EventArgs e)
        {
            if (selectTextureDialog.ShowDialog(this) == DialogResult.OK)
            {
                objectColor = null;

                if (!(FillingSelectionCanvas.Image is null))
                {
                    FillingSelectionCanvas.Image.Dispose();
                    FillingSelectionCanvas.Image = null;
                }

                texture = new Bitmap(selectTextureDialog.FileName);
                FillingSelectionCanvas.Image = new Bitmap(texture, FillingSelectionCanvas.Width, FillingSelectionCanvas.Height);

                UpdateFillingAlgorithm(sender, e);
            }
        }

        private void LightColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                lightColor = colorDialog.Color;

                if (!(LightSelectionCanvas.Image is null))
                {
                    LightSelectionCanvas.Image.Dispose();
                    LightSelectionCanvas.Image = null;
                }

                LightSelectionCanvas.Image = new Bitmap(LightSelectionCanvas.Width, LightSelectionCanvas.Height);

                using var g = Graphics.FromImage(LightSelectionCanvas.Image);
                g.Clear(lightColor);

                UpdateFillingAlgorithm(sender, e);
            }
        }

        private void UpdateFillingAlgorithm(object sender, EventArgs e)
        {
            if (polygonFiller is IDisposable dis)
                dis.Dispose();
            polygonFiller = Activator.CreateInstance(
                ColorInterpolationButton.Checked
                ? typeof(TriangleFillerWithColorInterpolation)
                : VectorInterpolationButton.Checked
                ? typeof(TriangleFillerWithVectorInterpolation)
                : throw new InvalidOperationException("Cannot create proper polygon filler instance"),
                drawArea, (float)Ks_slider.Value / 100, (float)Kd_slider.Value / 100, (float)M_slider.Value,
                objectColor, texture, lightColor, lightCoordinates,
                normalMapCheckBox.Checked && !(normalMap is null)
                ? normalMap : null) as PolygonFiller;

            Z_label.Text = Z_slider.Value.ToString();
            Ks_label.Text = ((float)Ks_slider.Value / 100).ToString();
            Kd_label.Text = ((float)Kd_slider.Value / 100).ToString();
            M_label.Text = M_slider.Value.ToString();

            shadows.Clear();
            foreach(var cloud in clouds)
                shadows.Add(CalcShadow(cloud));

            Redraw();
        }

        private void NormalMapButton_Click(object sender, EventArgs e)
        {
            if (selectNormalMapDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!(NormalMapCanvas.Image is null))
                {
                    NormalMapCanvas.Image.Dispose();
                    NormalMapCanvas.Image = null;
                }

                normalMap = new Bitmap(selectNormalMapDialog.FileName);
                NormalMapCanvas.Image = new Bitmap(normalMap, NormalMapCanvas.Width, NormalMapCanvas.Height);

                UpdateFillingAlgorithm(sender, e);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (selectObjDialog.ShowDialog(this) == DialogResult.OK)
            {
                FilenameLabel.Text = selectObjDialog.FileName;

                InitFile();

                UpdateFillingAlgorithm(sender, e);
            }
        }
    }
}
