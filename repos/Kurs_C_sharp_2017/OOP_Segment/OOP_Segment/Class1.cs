using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public static class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }
        public static double GetLength(Segment segment)
        {
            return Math.Sqrt( Math.Pow(segment.End.X-segment.Begin.X,2) + Math.Pow(segment.End.Y - segment.Begin.Y, 2));
        }
        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            if ((vector.X == segment.Begin.X && vector.Y == segment.Begin.Y)
                || (vector.X == segment.End.X && vector.Y == segment.End.Y))
                return true;
            double p; //Коэффициент. Если =[0,1], то точка лежит на отрезке
            p = (vector.X - segment.End.X) / (segment.Begin.X - segment.End.X);
            return ( p*segment.Begin.Y + (1 - p)*segment.End.Y == vector.Y ) && (p >= 0 || p <= 1); 
        }
        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector sum = new Vector();
            sum.X = vector1.X + vector2.X;
            sum.Y = vector1.Y + vector2.Y;
            return sum;
        }
    }
    public class Vector
    {
        public double X;
        public double Y;
    }
    public class Segment
    {
        public Vector Begin;
        public Vector End;
    }
}


/*return ( (vector.X - segment.Begin.X) / (segment.End.X - segment.Begin.X) 
                == (vector.Y - segment.Begin.Y) / (segment.End.Y - segment.Begin.Y) );
*/