using CommonClassLib;
using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PolygonFillerLib
{
    public abstract class PolygonFiller
    {
        private readonly (EdgeBucket Value, EdgeBucket Last)[] ET;
        private readonly List<EdgeBucket> AET;
        protected Bitmap drawArea;
        protected int yStart = int.MaxValue;
        protected int yEnd = -1;
        protected Polygon polygon;

        protected PolygonFiller(Polygon polygon, Bitmap drawArea)
        {
            ET = new (EdgeBucket Value, EdgeBucket Last)[drawArea.Height];
            AET = new List<EdgeBucket>(polygon.Edges.Value.Count);
            this.drawArea = drawArea;
            this.polygon = polygon;

            PrepareET(polygon);
        }

        public abstract void FillPolygon();

        protected void FillPolygon(Func<int, int, Color> getColorFunc)
        {
            using var fastBitmap = drawArea.FastLock();

            for (int y = yStart; y < yEnd; ++y)
            {
                EdgeBucket e = ET[y].Value;
                while (!(e is null))
                {
                    AET.Add(e);
                    e = e.Next;
                }

                var orderedX = AET.OrderBy(eb => eb.XOfYmin).ToArray();

                for (int i = 0; i < AET.Count; i += 2)
                {
                    for (float x = orderedX[i].XOfYmin; x <= orderedX[i + 1].XOfYmin; x++)
                        fastBitmap.SetPixel((int)x, y, getColorFunc((int)x, y));
                }

                AET.RemoveAll(eb => eb.Ymax == y + 1);
                AET.ForEach(eb => eb.XOfYmin += eb.InvSlope);
            }
        }

        

        private void PrepareET(Polygon polygon)
        {
            foreach (var e in polygon.Edges.Value)
            {
                if (Math.Abs(e.FirstVertex.Coordinates.Y - e.SecondVertex.Coordinates.Y) < 1e-3)
                    continue;

                Vertex lower, higher;
                
                if (e.FirstVertex.Coordinates.Y < e.SecondVertex.Coordinates.Y)
                {
                    lower = e.FirstVertex;
                    higher = e.SecondVertex;
                }
                else if (e.FirstVertex.Coordinates.Y > e.SecondVertex.Coordinates.Y)
                {
                    lower = e.SecondVertex;
                    higher = e.FirstVertex;
                }
                else
                    continue;

                if (ET[(int)lower.Coordinates.Y].Value is null)
                    ET[(int)lower.Coordinates.Y].Last
                        = ET[(int)lower.Coordinates.Y].Value
                        = new EdgeBucket(higher, lower);
                else
                    ET[(int)lower.Coordinates.Y].Last.Next = new EdgeBucket(higher, lower);

                if (yStart > (int)lower.Coordinates.Y) yStart = (int)lower.Coordinates.Y;
                if (yEnd < (int)higher.Coordinates.Y) yEnd = (int)higher.Coordinates.Y;
            }
        }
    }
}
