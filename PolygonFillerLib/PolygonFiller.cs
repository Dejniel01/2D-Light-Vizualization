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
        private readonly List<EdgeBucket>[] ET;
        private List<EdgeBucket> AET;
        protected Bitmap drawArea;
        protected int yStart = int.MaxValue;
        protected int yEnd = -1;
        public Polygon Polygon
        {
            get;
            set;
        }

        protected PolygonFiller(Bitmap drawArea)
        {
            ET = new List<EdgeBucket>[drawArea.Height];
            this.drawArea = drawArea;
        }

        public virtual void FillPolygon(Polygon polygon)
        {
            Polygon = polygon;
        }

        protected void FillPolygon(Func<int, int, Color> getColorFunc)
        {
            AET = new List<EdgeBucket>(Polygon.Edges.Value.Count);
            PrepareET(Polygon);

            using var fastBitmap = drawArea.FastLock();

            for (int y = yStart; y < yEnd; ++y)
            {
                if(!(ET[y] is null))
                    AET.AddRange(ET[y]);

                var orderedX = AET.OrderBy(eb => eb.XOfYmin).ToArray();

                for (int i = 0; i < AET.Count; i += 2)
                {
                    for (float x = orderedX[i].XOfYmin; x <= orderedX[i + 1].XOfYmin; x++)
                        if(x >= 0 && x < drawArea.Width)
                            fastBitmap.SetPixel((int)x, y, getColorFunc((int)x, y));
                }

                AET.RemoveAll(eb => eb.Ymax == y + 1);
                AET.ForEach(eb => eb.XOfYmin += eb.InvSlope);
            }
        }



        private void PrepareET(Polygon polygon)
        {
            Array.Fill(ET, null);
            yStart = int.MaxValue;
            yEnd = -1;
            foreach (var e in polygon.Edges.Value)
            {
                if (Math.Abs(e.FirstVertex.Coordinates.Y - e.SecondVertex.Coordinates.Y) < 1e-3)
                    continue;

                Vertex lower, higher;
                int firstX = (int)e.FirstVertex.Coordinates.X, firstY = (int)e.FirstVertex.Coordinates.Y;
                int secondX = (int)e.SecondVertex.Coordinates.X, secondY = (int)e.SecondVertex.Coordinates.Y;
                if (firstX < 0) firstX = 0;
                if (firstY < 0) firstY = 0;
                if (secondX < 0) secondX = 0;
                if (secondY < 0) secondY = 0;
                if (firstX >= drawArea.Width) firstX = drawArea.Width - 1;
                if (firstY >= drawArea.Height) firstY = drawArea.Height - 1;
                if (secondX >= drawArea.Width) secondX = drawArea.Width - 1;
                if (secondY >= drawArea.Height) secondY = drawArea.Height - 1;

                int lowerY = 0;
                int higherY = 0;

                if (firstY < secondY)
                {
                    lower = e.FirstVertex;
                    higher = e.SecondVertex;
                    lowerY = firstY;
                    higherY = secondY;
                }
                else if (firstY > secondY)
                {
                    lower = e.SecondVertex;
                    higher = e.FirstVertex;
                    lowerY = secondY;
                    higherY = firstY;
                }
                else
                    continue;

                if (ET[lowerY] is null)
                    ET[lowerY]
                        = new List<EdgeBucket>();

                    ET[lowerY].Add(new EdgeBucket(higher, lower));

                if (yStart > lowerY) yStart = lowerY;
                if (yEnd < higherY) yEnd = higherY;
            }
        }
    }
}
