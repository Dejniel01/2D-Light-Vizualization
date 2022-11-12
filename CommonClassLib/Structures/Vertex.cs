using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClassLib.Structures
{
    public class Vertex
    {
        public Vertex(Vector coordinates, Vector normalVector)
        {
            Coordinates = coordinates;
            NormalVector = normalVector;
        }

        public Vector Coordinates
        {
            get;
            set;
        }
        public Vector NormalVector
        {
            get;
            set;
        }
    }
}
