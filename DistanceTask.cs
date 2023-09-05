using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			//if (((x >= ax && x <= bx) || (x <= ax && x >= bx)) && ((y >= ay && y <= by) || (y <= ay && y >= by)))
   //         {
			//	return 0;
   //         }
			double sqA = (x - ax) * (x - ax) + (y - ay) * (y - ay), sqB = (x - bx) * (x - bx) + (y - by) * (y - by),
				sqC = (ax - bx) * (ax - bx) + (ay - by) * (ay - by);
			if (sqC + sqB < sqA || sqA + sqC < sqB)
			{
				return Math.Min(Math.Sqrt(sqA), Math.Sqrt(sqB));
			}
			if (sqB == sqA + sqC)
            {
				return Math.Sqrt(sqA);
            }
			if (sqA == sqB + sqC)
            {
				return Math.Sqrt(sqB);
            }
			double P = by - ay, Q = ax - bx, R = -ax * (by - ay) + ay * (bx - ax);
			double D = Math.Abs(P * x + Q * y + R) / Math.Sqrt(P * P + Q * Q);
			return D;
		
		}
	}
}