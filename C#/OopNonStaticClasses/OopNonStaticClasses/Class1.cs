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
            return Math.Sqrt((segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X) +
                             (segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y));
        }
        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            double x = vector.X, y = vector.Y, x1 = segment.Begin.X, x2 = segment.End.X,
                y1 = segment.Begin.Y, y2 = segment.End.Y;

            if ((x == x1 && y == y1) || (x == x2 && y == y2))
                return true;

            if ((x == x1 && x == x2 && y1 <= y && y <= y2)
               || (y == y1 && y == y2 && x1 <= x && x <= x2))
                return true;

            return (((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1) == 0)
                    && ((x1 < x && x < x2) || (x2 < x && x < x1)));
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

        public double GetLength()
        {
            Vector vector = new Vector();
            vector.X = X;
            vector.Y = Y;
            return Geometry.GetLength(vector);
        }

        public Vector Add(Vector vector2)
        {
            Vector vector1 = new Vector();
            vector1.X = X;
            vector1.Y = Y;
            return Geometry.Add(vector1, vector2);
        }

        public bool Belongs(Segment segment)
        {
            Vector vector = new Vector();
            vector.X = X;
            vector.Y = Y;
            return Geometry.IsVectorInSegment(vector, segment);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength()
        {
            Segment segment = new Segment();
            segment.Begin = Begin;
            segment.End = End;
            return Geometry.GetLength(segment);
        }

        public bool Contains(Vector vector)
        {
            Segment segment = new Segment();
            segment.Begin = Begin;
            segment.End = End;
            return Geometry.IsVectorInSegment(vector, segment);
        }
    }
}