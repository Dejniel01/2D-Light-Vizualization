using CommonClassLib;
using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public class TriangleFillerWithColorInterpolation : PolygonFiller
    {
        private readonly float ks;
        private readonly float kd;
        private readonly float m;
        private readonly Color objectColor;
        private readonly Color lightColor;
        private readonly Vector lightCoordinates;
        private Dictionary<Vector, (float r, float g, float b)> colorInVerticesDictionary;
        private Dictionary<(int x, int y), (float alfa, float beta, float gamma)> colorCoeficcientsDictionary;
        public TriangleFillerWithColorInterpolation(Polygon polygon, Bitmap drawArea, float ks, float kd, float m, Color objectColor, Color lightColor, Vector lightCoordinates)
            : base(polygon, drawArea)
        {
            this.ks = ks;
            this.kd = kd;
            this.m = m;
            this.objectColor = objectColor;
            this.lightColor = lightColor;
            this.lightCoordinates = lightCoordinates;

            colorCoeficcientsDictionary = new Dictionary<(int x, int y), (float alfa, float beta, float gamma)>();
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

            //if (colorCoeficcientsDictionary.TryGetValue((x, y), out (float alfa, float beta, float gamma) coef))
            //{
            //    (r, g, b) =
            //        (
            //            v1Color.r * coef.alfa + v2Color.r * coef.beta + v3Color.r * coef.gamma,
            //            v1Color.g * coef.alfa + v2Color.g * coef.beta + v3Color.g * coef.gamma,
            //            v1Color.b * coef.alfa + v2Color.b * coef.beta + v3Color.b * coef.gamma
            //        );
            //}
            //else
            //{
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

                //colorCoeficcientsDictionary.Add((x, y), (alfa, beta, gamma));
            //}
            return Color.FromArgb(
                (int)r.Map(0, 1, 0, 255),
                (int)g.Map(0, 1, 0, 255),
                (int)b.Map(0, 1, 0, 255));
        }

        private Dictionary<Vector, (float r, float g, float b)> CalculateColorsForTriangleVertices()
        {
            var colorDictionary = new Dictionary<Vector, (float r, float g, float b)>(3);

            (float r, float g, float b) mappedObjectColor =
                (
                    ((float)objectColor.R).Map(0, 255, 0, 1),
                    ((float)objectColor.G).Map(0, 255, 0, 1),
                    ((float)objectColor.B).Map(0, 255, 0, 1)
                );

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
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.r * mappedObjectColor.r),
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.g * mappedObjectColor.g),
                        (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.b * mappedObjectColor.b)
                    ));
            }

            return colorDictionary;
        }
    }
}
