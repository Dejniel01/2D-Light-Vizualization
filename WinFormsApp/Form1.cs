using CommonClassLib;
using CommonClassLib.Structures;
using FileParserLib.ObjParser;
using PolygonFillerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly List<Triangle> triangles;
        private readonly Bitmap drawArea;

        private Color lightColor = Color.White;
        private Color objectColor = Color.Yellow;
        private readonly Vector lightCoordinates;

        private Timer timer;
        private float r = 0;
        private float theta = 0;

        private Stopwatch stopwatch = new Stopwatch();
        private int frames = 0;
        private long prevElapsed = 0;
        private float fps = 0;

        public Form1()
        {
            InitializeComponent();

            triangles = ObjParser.ParseObjToTriangleCollection("./hemisphereAVG.obj");

            drawArea = new Bitmap(600, 800);
            this.Canvas.Image = drawArea;

            lightCoordinates = new Vector(drawArea.Width / 2, drawArea.Height / 2, -1);

            FitTrianglesToDrawArea();

            Redraw();

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 5;
            timer.Start();
            stopwatch.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lightCoordinates.X = drawArea.Width / 2 + (float)(r * Math.Cos(theta));
            lightCoordinates.Y = drawArea.Height / 2 + (float)(r * Math.Sin(theta));

            theta += 0.01f;
            r += 0.25f;

            Redraw();

            prevElapsed = stopwatch.ElapsedMilliseconds;
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
            z_selector.Value = (decimal)z + 100;
            z_selector.Minimum = (decimal)z + 10;
        }

        private void Redraw()
        {
            using Graphics g = Graphics.FromImage(drawArea);

            g.Clear(Color.White);

            lightCoordinates.Z = (float)z_selector.Value;

            foreach (var t in triangles)
            {
                var polfil = new TriangleFillerWithColorInterpolation(t, drawArea, (float)ks_selector.Value, (float)kd_selector.Value, (float)m_selector.Value, objectColor, lightColor, lightCoordinates);
                polfil.FillPolygon();

                t.DrawShape(drawArea);
            }

            g.FillEllipse(Brushes.Yellow, lightCoordinates.X - 10, lightCoordinates.Y - 10, 20, 20);

            g.DrawString($"Redrawn at {DateTime.Now}", DefaultFont, Brushes.Black, 5, 5);
            g.DrawString(string.Format("FPS: {0:N2}", 1000.0 / (stopwatch.ElapsedMilliseconds - prevElapsed)), DefaultFont, Brushes.Black, 5, 20);

            Canvas.Invalidate();
        }

        private void Selector_ValueChanged(object sender, EventArgs e)
        {
            Redraw();
        }
    }
}
