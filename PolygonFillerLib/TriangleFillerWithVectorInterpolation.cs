using CommonClassLib;
using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public class TriangleFillerWithVectorInterpolation : TriangleFiller
    {
        private readonly float ks;
        private readonly float kd;
        private readonly float m;
        private readonly Vector lightCoordinates;
        private readonly (float r, float g, float b) mappedObjectColor;
        private readonly (float r, float g, float b) mappedLightColor;
        public TriangleFillerWithVectorInterpolation(Polygon polygon, Bitmap drawArea, float ks, float kd, float m, Color objectColor, Color lightColor, Vector lightCoordinates)
            : base(polygon, drawArea)
        {
            this.ks = ks;
            this.kd = kd;
            this.m = m;
            this.lightCoordinates = lightCoordinates;

            mappedObjectColor =
                (
                    ((float)objectColor.R).Map(0, 255, 0, 1),
                    ((float)objectColor.G).Map(0, 255, 0, 1),
                    ((float)objectColor.B).Map(0, 255, 0, 1)
                );

            mappedLightColor =
                (
                    ((float)lightColor.R).Map(0, 255, 0, 1),
                    ((float)lightColor.G).Map(0, 255, 0, 1),
                    ((float)lightColor.B).Map(0, 255, 0, 1)
                );
        }
        public override void FillPolygon()
        {
            base.FillPolygon(GetColor);
        }

        private Color GetColor(int x, int y)
        {
            var (alfa, beta, gamma) = CalculateCoefficients(x, y);

            Vector v = polygon.Vertices[0].Coordinates * alfa
                + polygon.Vertices[1].Coordinates * beta
                + polygon.Vertices[2].Coordinates * gamma;

            Vector vn = polygon.Vertices[0].NormalVector.GetNormalizedVector() * alfa
                + polygon.Vertices[1].NormalVector.GetNormalizedVector() * beta
                + polygon.Vertices[2].NormalVector.GetNormalizedVector() * gamma;

            Vector l = lightCoordinates - v;
            Vector r = 2 * Utils.DotProduct(vn, l) * (vn - l);

            float cosNL = Utils.DotProduct(vn.GetNormalizedVector(), l.GetNormalizedVector());
            if (cosNL < 0) cosNL = 0;

            float cosVR = Utils.DotProduct(new Vector(0, 0, 1), r.GetNormalizedVector());
            var cosmVR = cosVR <= 0 ? 0 : Math.Pow(cosVR, m);

            (float r, float g, float b) mappedColor = (
                    (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.r * mappedObjectColor.r),
                    (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.g * mappedObjectColor.g),
                    (float)(kd * cosNL + ks * cosmVR) * (mappedLightColor.b * mappedObjectColor.b)
                );

            return Color.FromArgb((int)mappedColor.r.Map(0, 1, 0, 255), (int)mappedColor.g.Map(0, 1, 0, 255), (int)mappedColor.b.Map(0, 1, 0, 255));
        }
    }
}
