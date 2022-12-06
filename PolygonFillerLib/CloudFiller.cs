using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PolygonFillerLib
{
    public class CloudFiller : PolygonFiller
    {
        private Color[,] texture;
        public CloudFiller(Bitmap drawArea, Bitmap texture) : base(drawArea)
        {
            this.texture = new Color[drawArea.Width, drawArea.Height];
            //niestety tekstura jest zapisana w złym formacie, więc nie mogę korzystać z fast bitmap
            //nie zdążę tego poprawić
            //using var fastTexture = texture.FastLock();
            for (int x = 0; x < drawArea.Width; x++)
                for (int y = 0; y < drawArea.Height; y++)
                    this.texture[x, y] = texture.GetPixel(x % texture.Width, y % texture.Height);
        }

        public override void FillPolygon(Polygon polygon)
        {
            base.FillPolygon(polygon);
            int minX = (int)polygon.Vertices.Min(v => v.Coordinates.X);
            int minY = (int)polygon.Vertices.Min(v => v.Coordinates.Y);
            FillPolygon((x, y) => texture[x - minX, y - minY]);
        }
    }
}
