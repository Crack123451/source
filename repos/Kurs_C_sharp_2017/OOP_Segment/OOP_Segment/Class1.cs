using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Geometry
    {
        static double GetLength(Vector vectorDot1, Vector vectorDot2)
        {
            double lenght;
            lenght = Math.Sqrt(Math.Pow(vectorDot2.X - vectorDot1.X, 2) + Math.Pow(vectorDot2.Y - vectorDot1.Y, 2));
            return lenght;
        }
        static Vector[] Add(Vector[] dotVector1, Vector[] dotVector2)
        {
            Vector[] sum = new Vector[] { new Vector(), new Vector() };
            sum[0].X = dotVector1[0].X + dotVector2[0].X;
            sum[1].X = dotVector1[1].X + dotVector2[1].X;
            sum[0].Y = dotVector1[0].Y + dotVector2[0].Y;
            sum[1].Y = dotVector1[1].Y + dotVector2[1].Y;
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
        Geometry.GetLength();
    }
}