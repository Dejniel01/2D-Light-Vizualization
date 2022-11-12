using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClassLib.Structures
{
    public class Edge
    {
        public Edge(Vertex v1, Vertex v2)
        {
            FirstVertex = v1;
            SecondVertex = v2;
        }
        public Vertex FirstVertex
        {
            get;
            set;
        }
        public Vertex SecondVertex
        {
            get;
            set;
        }
    }
}
