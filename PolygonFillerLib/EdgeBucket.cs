using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonFillerLib
{
    internal class EdgeBucket
    {
        internal EdgeBucket(Vertex higher, Vertex lower)
        {

            Ymax = (int)higher.Coordinates.Y;
            XOfYmin = lower.Coordinates.X;
            InvSlope = (higher.Coordinates.X - lower.Coordinates.X) / (higher.Coordinates.Y - lower.Coordinates.Y);
            Next = null;
        }

        internal int Ymax
        {
            get;
            set;
        }
        internal float XOfYmin
        {
            get;
            set;
        }
        internal float InvSlope
        {
            get;
            set;
        }
        internal EdgeBucket Next
        {
            get;
            set;
        }
    }
}
