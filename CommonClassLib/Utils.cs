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

        public static float Heron(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            var a = Length(x1, y1, x2, y2);
            var b = Length(x1, y1, x3, y3);
            var c = Length(x2, y2, x3, y3);
            var p = (a + b + c) / 2;

            var Psq = p * (p - a) * (p - b) * (p - c);

            return Psq > 0 ? (float)Math.Sqrt(Psq) : 0;
        }
    }
}
