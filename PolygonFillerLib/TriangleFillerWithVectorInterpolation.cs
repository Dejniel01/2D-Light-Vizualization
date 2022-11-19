using CommonClassLib;
using CommonClassLib.Structures;
using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PolygonFillerLib
{
	public class TriangleFillerWithVectorInterpolation : TriangleFiller
	{
		private readonly (float r, float g, float b) mappedLightColor;
		public TriangleFillerWithVectorInterpolation(Bitmap drawArea, float ks, float kd, float m, Color? objectColor, Bitmap texture, Color lightColor, Vector lightCoordinates, Bitmap normalMap)
			: base(drawArea, ks, kd, m, objectColor, texture, lightColor, lightCoordinates, normalMap)
		{
			mappedLightColor =
					(
						((float)lightColor.R).Map(0, 255, 0, 1),
						((float)lightColor.G).Map(0, 255, 0, 1),
						((float)lightColor.B).Map(0, 255, 0, 1)
					);
		}
		public override void FillPolygon(Polygon polygon)
		{
			base.FillPolygon(polygon);

			base.FillPolygon(GetColor);
		}

		private Color GetColor(int x, int y)
		{
			var (alfa, beta, gamma) = CalculateCoefficients(x, y);

			Vector v = Polygon.Vertices[0].Coordinates * alfa
				+ Polygon.Vertices[1].Coordinates * beta
				+ Polygon.Vertices[2].Coordinates * gamma;

			Vector vn = Polygon.Vertices[0].NormalVector.GetNormalizedVector() * alfa
				+ Polygon.Vertices[1].NormalVector.GetNormalizedVector() * beta
				+ Polygon.Vertices[2].NormalVector.GetNormalizedVector() * gamma;

			vn = ApplyNormalMap(vn, x, y);

			float multiplier = GetMultiplier(v, vn);

			var mappedObjectColor = CalculateObjectColor((int)v.X, (int)v.Y);
			
			(float r, float g, float b) mappedColor = (
					multiplier * mappedLightColor.r * mappedObjectColor.R,
					multiplier * mappedLightColor.g * mappedObjectColor.G,
					multiplier * mappedLightColor.b * mappedObjectColor.B
				);

			return Color.FromArgb((int)mappedColor.r.Map(0, 1, 0, 255), (int)mappedColor.g.Map(0, 1, 0, 255), (int)mappedColor.b.Map(0, 1, 0, 255));
		}
	}
}
