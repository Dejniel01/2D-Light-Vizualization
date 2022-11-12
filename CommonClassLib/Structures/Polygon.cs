using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CommonClassLib.Structures
{
    public abstract class Polygon
    {
        public Polygon()
        {
            Vertices = new List<Vertex>();
            Edges = new Lazy<List<Edge>>(() => GetEdges());
        }
        public Polygon(List<Vertex> vertices) : this()
        {
            Vertices = vertices;
        }
        public List<Vertex> Vertices
        {
            get;
            set;
        }

        public Lazy<List<Edge>> Edges
        {
            get;
            private set;
        }

        public void DrawShape(Bitmap drawArea)
        {
            using Graphics g = Graphics.FromImage(drawArea);
            g.DrawLines(Pens.Black, Vertices.Select(v => new PointF(v.Coordinates.X, v.Coordinates.Y)).ToArray());
            g.DrawLine(Pens.Black, Vertices[^1].Coordinates.X, Vertices[^1].Coordinates.Y, Vertices[0].Coordinates.X, Vertices[0].Coordinates.Y);
        }

        private List<Edge> GetEdges()
        {
            var edges = new List<Edge>(Vertices.Count);
            for (int i = 0; i < Vertices.Count; i++)
                edges.Add(new Edge(Vertices[i], Vertices[Utils.Inc(i, Vertices.Count)]));

            return edges;
        }
    }
}
