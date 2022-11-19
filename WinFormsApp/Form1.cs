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

		public Form1()
		{
			InitializeComponent();

			FilenameLabel.Text = "../../../Resources/Obj/Sphere.obj";

			InitDrawAreas();

			InitFile();

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

			Redraw();
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
			Z_slider.Value = (int)z + 100;
			Z_slider.Minimum = (int)z + 10;

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

				if(EdgesCheckbox.Checked)
					t.DrawShape(drawArea);
			}

			if(LightCheckBox.Checked)
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
			if(selectObjDialog.ShowDialog(this) == DialogResult.OK)
            {
				FilenameLabel.Text = selectObjDialog.FileName;

				InitFile();

				UpdateFillingAlgorithm(sender, e);
            }
        }
    }
}
