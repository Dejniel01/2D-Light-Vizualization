using CommonClassLib;
using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public class TriangleFillerWithColorInterpolation : TriangleFiller
    {
        private Dictionary<Vector, (float r, float g, float b)> colorInVerticesDictionary;

        public TriangleFillerWithColorInterpolation(Bitmap drawArea, float ks, float kd, float m, Color? objectColor, Bitmap texture, Color lightColor, Vector lightCoordinates, Bitmap normalMap)
            : base(drawArea, ks, kd, m, objectColor, texture, lightColor, lightCoordinates, normalMap)
        { }

        public override void FillPolygon(Polygon polygon)
        {
            base.FillPolygon(polygon);

            colorInVerticesDictionary = CalculateColorsForTriangleVertices();

            base.FillPolygon(GetColor);
        }

        private Color GetColor(int x, int y)
        {
            float r, g, b;

            var v1Color = colorInVerticesDictionary[Polygon.Vertices[0].Coordinates];
            var v2Color = colorInVerticesDictionary[Polygon.Vertices[1].Coordinates];
            var v3Color = colorInVerticesDictionary[Polygon.Vertices[2].Coordinates];

            var (alfa, beta, gamma) = CalculateCoefficients(x, y);

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

            foreach (var v in Polygon.Vertices)
            {
                var vn = ApplyNormalMap(v.NormalVector, (int)v.Coordinates.X, (int)v.Coordinates.Y);

                var mappedObjectColor = CalculateObjectColor((int)v.Coordinates.X, (int)v.Coordinates.Y);

                float multiplier = GetMultiplier(v.Coordinates, vn);

                colorDictionary.Add(
                    v.Coordinates,
                    (
                        multiplier * lightColor.R * mappedObjectColor.R,
                        multiplier * lightColor.G * mappedObjectColor.G,
                        multiplier * lightColor.B * mappedObjectColor.B
                    ));
            }

            return colorDictionary;
        }
    }
}
