using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClassLib
{
    public static class Utils
    {
        public static int Inc(int i, int n) => (i + 1) % n;

        public static float Map(this float v, float in1, float in2, float out1, float out2)
        {
            float t = (v - in1) / (in2 - in1);
            if (t > 1f)
                return out2;
            if (t < 0f)
                return out1;
            return out1 + (out2 - out1) * t;
        }

        public static float DotProduct(Vector v1, Vector v2) => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;

        public static float Length(float x1, float y1, float x2, float y2)
            => (float)Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

        public static Vector CrossProduct(Vector v1, Vector v2)
            => new Vector(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);

        public static float TriangleArea(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            float v1x = x2 - x1;
            float v1y = y2 - y1;
            float v2x = x3 - x1;
            float v2y = y3 - y1;

            return Math.Abs(v1x * v2y - v1y * v2x) / 2;
        }

        public static Vector MultiplyMatrixAndVector((Vector V1, Vector V2, Vector V3) M, Vector v)
            => new Vector(
                M.V1.X * v.X + M.V2.X * v.Y + M.V3.X * v.Z,
                M.V1.Y * v.X + M.V2.Y * v.Y + M.V3.Y * v.Z,
                M.V1.Z * v.X + M.V2.Z * v.Y + M.V3.Z * v.Z
                );
    }
}
