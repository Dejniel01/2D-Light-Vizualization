using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonFillerLib
{
    public static class TriangleFillerCache
    {
        public static Dictionary<(Polygon, int, int), (float, float, float)> CoefficientsDictionary
        {
            get;
            private set;
        } = new Dictionary<(Polygon, int, int), (float, float, float)>();
    }
}
