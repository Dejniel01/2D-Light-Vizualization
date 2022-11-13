using CommonClassLib;
using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public abstract class TriangleFiller : PolygonFiller
    {
        protected TriangleFiller(Polygon polygon, Bitmap drawArea) : base(polygon, drawArea)
        { }

        protected (float alfa, float beta, float gamma) CalculateCoefficients(int x, int y)
        {
            if (TriangleFillerCache.CoefficientsDictionary.TryGetValue((polygon, x, y), out var coef))
                return (coef.Item1, coef.Item2, coef.Item3);

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

            TriangleFillerCache.CoefficientsDictionary.Add((polygon, x, y), (P1 / P, P2 / P, P3 / P));

            return (P1 / P, P2 / P, P3 / P);
        }
    }
}
