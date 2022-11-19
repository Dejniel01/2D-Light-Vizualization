using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonFillerLib
{
    public static class TriangleFillerCache
    {
        public static void Clear()
        {
            CoefficientsDictionary.Clear();
            NormalMapDictionary.Clear();
            MappedObjectColorDictionary.Clear();
        }

        public static Dictionary<(Polygon, int, int), (float, float, float)> CoefficientsDictionary
        {
            get;
            private set;
        } = new Dictionary<(Polygon, int, int), (float, float, float)>();

        public static Dictionary<(Polygon, int, int), Vector> NormalMapDictionary
        {
            get;
            private set;
        } = new Dictionary<(Polygon, int, int), Vector>();

        public static Dictionary<(Polygon, int, int), (float, float, float)> MappedObjectColorDictionary
        {
            get;
            private set;
        } = new Dictionary<(Polygon, int, int), (float, float, float)>();
    }
}
