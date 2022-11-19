using CommonClassLib;
using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public abstract class TriangleFiller : PolygonFiller
    {
        protected float ks;
        protected float kd;
        protected float m;
        protected Color? objectColor;
        protected Bitmap texture;
        protected (float R, float G, float B) lightColor;
        protected Vector lightCoordinates;
        protected Bitmap normalMap;

        protected TriangleFiller(Bitmap drawArea, float ks, float kd, float m, Color? objectColor, Bitmap texture, Color lightColor, Vector lightCoordinates, Bitmap normalMap) : base(drawArea)
        {
            TriangleFillerCache.CoefficientsDictionary.Clear();
            TriangleFillerCache.Clear();

            this.ks = ks;
            this.kd = kd;
            this.m = m;
            this.objectColor = objectColor;
            this.texture = texture;
            this.lightColor = (
                ((float)lightColor.R).Map(0, 255, 0, 1),
                ((float)lightColor.G).Map(0, 255, 0, 1),
                ((float)lightColor.B).Map(0, 255, 0, 1)
                );
            this.lightCoordinates = lightCoordinates;
            this.normalMap = normalMap;
        }

        public override void FillPolygon(Polygon polygon)
        {
            base.FillPolygon(polygon);
        }

        protected (float alfa, float beta, float gamma) CalculateCoefficients(int x, int y)
        {
            if (TriangleFillerCache.CoefficientsDictionary.TryGetValue((Polygon, x, y), out var coef))
                return (coef.Item1, coef.Item2, coef.Item3);

            var P1 = Utils.TriangleArea(
                Polygon.Vertices[1].Coordinates.X, Polygon.Vertices[1].Coordinates.Y,
                Polygon.Vertices[2].Coordinates.X, Polygon.Vertices[2].Coordinates.Y,
                x, y);
            var P2 = Utils.TriangleArea(
                Polygon.Vertices[0].Coordinates.X, Polygon.Vertices[0].Coordinates.Y,
                Polygon.Vertices[2].Coordinates.X, Polygon.Vertices[2].Coordinates.Y,
                x, y);
            var P3 = Utils.TriangleArea(
                Polygon.Vertices[0].Coordinates.X, Polygon.Vertices[0].Coordinates.Y,
                Polygon.Vertices[1].Coordinates.X, Polygon.Vertices[1].Coordinates.Y,
                x, y);
            var P = P1 + P2 + P3;

            var alfa = P1 / P;
            var beta = P2 / P;
            var gamma = P3 / P;

            TriangleFillerCache.CoefficientsDictionary.Add((Polygon, x, y), (alfa, beta, gamma));

            return (alfa, beta, gamma);
        }

        protected Vector ApplyNormalMap(Vector vn, int x, int y)
        {
            if (TriangleFillerCache.NormalMapDictionary.TryGetValue((Polygon, x, y), out var v))
                return v;

            if (!(normalMap is null))
            {
                using var fastNormalMap = normalMap.FastLock();
                var normalPixel = fastNormalMap.GetPixel(x % normalMap.Width, y % normalMap.Height);

                var vnt = new Vector(
                    ((float)normalPixel.R).Map(0, 255, -1, 1),
                    ((float)normalPixel.G).Map(0, 255, -1, 1),
                    ((float)normalPixel.B).Map(0, 255, 0, 1)
                    );

                var b = Utils.CrossProduct(vn, new Vector(0, 0, 1));
                if (Math.Abs(b.X) < 1e-4 && Math.Abs(b.Y) < 1e-4 && Math.Abs(b.Y) < 1e-4)
                    b = new Vector(0, 1, 0);

                var t = Utils.CrossProduct(b, vn);

                var ret = Utils.MultiplyMatrixAndVector((t, b, vn), vnt);
                TriangleFillerCache.NormalMapDictionary.Add((Polygon, x, y), ret);
                return ret;
            }

            return vn;
        }

        protected (float R, float G, float B) CalculateObjectColor(int x, int y)
        {
            if (TriangleFillerCache.MappedObjectColorDictionary.TryGetValue((Polygon, x, y), out var color))
                return color;

            if (objectColor.HasValue)
            {
                var c = (
                    ((float)objectColor.Value.R).Map(0, 255, 0, 1),
                    ((float)objectColor.Value.G).Map(0, 255, 0, 1),
                    ((float)objectColor.Value.B).Map(0, 255, 0, 1)
                    );
                TriangleFillerCache.MappedObjectColorDictionary.Add((Polygon, x, y), c);
                return c;
            }

            using (var fastTexture = texture.FastLock())
            {
                var pixel = fastTexture.GetPixel(x % fastTexture.Width, y % fastTexture.Height);

                var c = (
                    ((float)pixel.R).Map(0, 255, 0, 1),
                    ((float)pixel.G).Map(0, 255, 0, 1),
                    ((float)pixel.B).Map(0, 255, 0, 1)
                    );
                TriangleFillerCache.MappedObjectColorDictionary.Add((Polygon, x, y), c);
                return c;
            }
        }

        protected float GetMultiplier(Vector v, Vector vn)
        {
            Vector l = lightCoordinates - v;
            Vector r = 2 * Utils.DotProduct(vn, l) * vn - l;

            float cosNL = Utils.DotProduct(vn.GetNormalizedVector(), l.GetNormalizedVector());
            if (cosNL < 0) cosNL = 0;

            float cosVR = Utils.DotProduct(new Vector(0, 0, 1), r.GetNormalizedVector());
            float cosmVR = cosVR <= 0 ? 0 : (float)Math.Pow(cosVR, m);

            return kd * cosNL + ks * cosmVR;
        }
    }
}
