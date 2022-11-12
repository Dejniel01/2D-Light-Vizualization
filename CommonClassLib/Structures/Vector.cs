using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CommonClassLib.Structures
{
    public class Vector
    {
        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X
        {
            get;
            set;
        }
        public float Y
        {
            get;
            set;
        }
        public float Z
        {
            get;
            set;
        }

        public Vector GetNormalizedVector()
        {
            return this / (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return v1 + (-v2);
        }

        public static Vector operator /(Vector v, float d)
        {
            if (d == 0) throw new ArgumentException("Cannot divide by 0", nameof(d));

            return v * (1 / d);
        }

        public static Vector operator *(Vector v, float d)
        {
            return new Vector(v.X * d, v.Y * d, v.Z * d);
        }

        public static Vector operator *(float d, Vector v)
        {
            return v * d;
        }
    }
}
