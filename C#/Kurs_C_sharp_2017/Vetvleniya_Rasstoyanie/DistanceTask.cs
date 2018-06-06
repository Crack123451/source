using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
        static double GetLength(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double GetPerpendicular(double b, double c, double a)
        {
            double p = (a + b + c) / 2;
            return 2*Math.Sqrt(p*(p-a)*(p-b)*(p-c))/a;
        }
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            double left = GetLength(x, ax, y, ay);
            double right = GetLength(x, bx, y, by);
            double center = GetLength(x, (ax + bx) / 2, (ay + by) / 2, y);

            double ab = GetLength(ax, bx, ay, by);
            double perpendicular = GetPerpendicular (left,right,ab);

            if (Math.Abs(Math.Sqrt(Math.Pow(ax - x, 2) + Math.Pow(ay - y, 2)) 
                + Math.Sqrt(Math.Pow(bx - x, 2) + Math.Pow(by - y, 2)) 
                - Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2))) < 0.01)
                return 0.0;
            else
            {
                if( ab*ab+left*left > right*right && ab*ab +right*right >left*left)
                    return perpendicular;
                else if (right < left)
                    return right;
                else
                    return left;
            }
		}
	}
}

//(x >= ax && x <= bx) && (y >= ay && y <= by))
//if ((((provreca1>=0 && provreca1<=1) && (provreca2 >= 0 && provreca2 <= 1))) || ((x >= ax && x <= bx && y ==ay && y== by) || (y >= ay && y <= by && x == ax && x == bx)))

//double provreca1 = (x - bx) / (ax - bx);
//double provreca2 = (y - by) / (ay - by);
