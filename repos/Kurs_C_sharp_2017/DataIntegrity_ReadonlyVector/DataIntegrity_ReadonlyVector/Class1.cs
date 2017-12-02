using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVectorTask
{
    public class ReadOnlyVector
    {
        public readonly double X;
        public readonly double Y;

        public ReadOnlyVector (double x, double y)
        {
            X = x;
            Y = y;
        }

        public ReadOnlyVector Add(ReadOnlyVector other)
        {
            ReadOnlyVector vector = new ReadOnlyVector(X,Y);
            ReadOnlyVector sum = new ReadOnlyVector(other.X+X, other.X+X);
            return sum;
        }

        public ReadOnlyVector WithX(double x)
        {
            ReadOnlyVector vector = new ReadOnlyVector(x, Y);
            return vector;
        }
        public ReadOnlyVector WithY(double y)
        {
            ReadOnlyVector vector = new ReadOnlyVector(X, y);
            return vector;
        }
    }
}

