using System;

namespace Billiards
{
	public static class BilliardsTask
	{
		public static double BounceWall(double directionRadians, double wallInclinationRadians)
		{
            double reflectionAngle = 2*Math.PI - directionRadians - Math.Abs(2*wallInclinationRadians);
			return reflectionAngle;
		}
	}
}