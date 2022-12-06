using CommonClassLib.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
    public class ShadowFiller : PolygonFiller
    {
        public ShadowFiller(Bitmap drawArea) : base(drawArea)
        {
        }

        public override void FillPolygon(Polygon polygon)
        {
            base.FillPolygon(polygon);
            FillPolygon((x, y) => Color.FromArgb(20, 20, 20));
        }
    }
}
