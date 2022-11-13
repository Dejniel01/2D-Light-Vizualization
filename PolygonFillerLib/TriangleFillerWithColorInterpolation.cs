using CommonClassLib;
using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public class TriangleFillerWithColorInterpolation : TriangleFiller, IDisposable
    {
        private readonly float ks;
        private readonly float kd;
        private readonly float m;
        private readonly Color? objectColor;
        private readonly Bitmap texture;
        private readonly Color lightColor;
        private readonly Vector lightCoordinates;
        private Dictionary<Vector, (float r, float g, float b)> colorInVerticesDictionary;

        public TriangleFillerWithColorInterpolation(Polygon polygon, Bitmap drawArea, float ks, float kd, float m, Color? objectColor, Bitmap texture, Color lightColor, Vector lightCoordinates)
            : base(polygon, drawArea)
        {
            this.ks = ks;
            this.kd = kd;
            this.m = m;
            this.objectColor = objectColor;
            this.texture = texture;
            this.lightColor = lightColor;
            this.lightCoordinates = lightCoordinates;
        }

        public override void FillPolygon()
        {
            colorInVerticesDictionary = CalculateColorsForTriangleVertices();

            base.FillPolygon(GetColor);
        }

        private Color GetColor(int x, int y)
        {
            float r, g, b;

            var v1Color = colorInVerticesDictionary[polygon.Vertices[0].Coordinates];
            var v2Color = colorInVerticesDictionary[polygon.Vertices[1].Coordinates];
            var v3Color = colorInVerticesDictionary[polygon.Vertices[2].Coordinates];

            var P1 = Utils.Heron(
                polygon.Vertices[1].Coordinates.X, polygon.Vertices[1].Coordinates.Y,
                polygon.Vertices[2].Coordinates.X, polygon.Vertices[2].Coordinates.Y,
                x, y);
            var P2 = Utils.Heron(
                polygon.Vertices[0].Coordinates.X, polygon.Vertices[0].Coordinates.Y,
                polygon.Vertices[2].Coordinates.X, polygon.Vertices[2].Coordinates.Y,
                x, y);
            var P3 = Utils.Heron(
                polygon.Vertices[0].Coordinates.X, polygon.Vertices[0].Coordinates.Y,
                polygon.Vertices[1].Coordinates.X, polygon.Vertices[1].Coordinates.Y,
                x, y);
            var P = P1 + P2 + P3;

            float alfa = P1 / P;
            float beta = P2 / P;
            float gamma = P3 / P;

            (r, g, b) =
                (
                    v1Color.r * alfa + v2Color.r * beta + v3Color.r * gamma,
                    v1Color.g * alfa + v2Color.g * beta + v3Color.g * gamma,
                    v1Color.b * alfa + v2Color.b * beta + v3Color.b * gamma
                );

            return Color.FromArgb(
                (int)r.Map(0, 1, 0, 255),
                (int)g.Map(0, 1, 0, 255),
                (int)b.Map(0, 1, 0, 255));
        }

        private Dictionary<Vector, (float r, float g, float b)> CalculateColorsForTriangleVertices()
        {
            var colorDictionary = new Dictionary<Vector, (float r, float g, float b)>(3);

            (float r, float g, float b) mappedObjectColor = objectColor.HasValue ?
                (
                    ((float)objectColor.Value.R).Map(0, 255, 0, 1),
                    ((float)objectColor.Value.G).Map(0, 255, 0, 1),
                    ((float)objectColor.Value.B).Map(0, 255, 0, 1)
                ) : (float.NaN, float.NaN, float.NaN);

            (float r, float g, float b) mappedLightColor =
                (
                    ((float)lightColor.R).Map(0, 255, 0, 1),
                    ((float)lightColor.G).Map(0, 255, 0, 1),
                    ((float)lightColor.B).Map(0, 255, 0, 1)
                );


            foreach (var v in polygon.Vertices)
            {
                Vector l = lightCoordinates - v.Coordinates;
                Vector r = 2 * Utils.DotProduct(v.NormalVector, l) * (v.NormalVector - l);

                float cosNL = Utils.DotProduct(v.NormalVector.GetNormalizedVector(), l.GetNormalizedVector());
                if (cosNL < 0) cosNL = 0;

                float cosVR = Utils.DotProduct(new Vector(0, 0, 1), r.GetNormalizedVector());
                var cosmVR = cosVR <= 0 ? 0 : Math.Pow(cosVR, m);

                colorDictionary.Add(
                    v.Coordinates,
                    (
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.r *
                            (float.IsNaN(mappedObjectColor.r)
                            ? ((float)texture.GetPixel((int)v.Coordinates.X % texture.Width, (int)v.Coordinates.Y % texture.Height).R).Map(0, 255, 0, 1)
                            : mappedObjectColor.r)),
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.g *
                            (float.IsNaN(mappedObjectColor.g)
                            ? ((float)texture.GetPixel((int)v.Coordinates.X % texture.Width, (int)v.Coordinates.Y % texture.Height).G).Map(0, 255, 0, 1)
                            : mappedObjectColor.g)),
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.b *
                            (float.IsNaN(mappedObjectColor.b)
                            ? ((float)texture.GetPixel((int)v.Coordinates.X % texture.Width, (int)v.Coordinates.Y % texture.Height).B).Map(0, 255, 0, 1)
                            : mappedObjectColor.b))
                    ));
            }

            return colorDictionary;
        }

        public void Dispose()
        {
            texture?.Dispose();
        }
    }
}
