using System;
using System.Collections;
using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		public static double[,] MedianFilter(double[,] original)
		{
            var resultFilter = new double[original.GetLength(0), original.GetLength(1)];
            for (int x = 0; x < original.GetLength(0); x++)
                for (int y = 0; y < original.GetLength(1); y++)
                    resultFilter[x, y] = ResultPixel(x, y, original);
			return resultFilter;
		}

        public static double ResultPixel(int x, int y, double[,] original)
        {
            double median=0;
            double[] matrix;
            ArrayList resultPixel = new ArrayList();
            if (y == 0)
            {
                if (x == 0)
                    matrix = new double[4] { original[x, y], original[x + 1, y], original[x, y + 1], original[x + 1, y + 1] };
                else if (x == original.GetLength(0) - 1)
                    matrix = new double[4] { original[x, y], original[x - 1, y], original[x, y + 1], original[x - 1, y + 1] };
                else
                    matrix = new double[6] { original[x, y], original[x + 1, y], original[x - 1, y], original[x, y + 1], original[x + 1, y + 1], original[x - 1, y + 1] };
            }
            else if (y == original.GetLength(1) - 1)
            {
                if (x == 0)
                    matrix = new double[4] { original[x, y], original[x + 1, y], original[x, y - 1], original[x + 1, y - 1] };
                else if (x == original.GetLength(0) - 1)
                    matrix = new double[4] { original[x, y], original[x - 1, y], original[x, y - 1], original[x - 1, y - 1] };
                else
                    matrix = new double[6] { original[x, y], original[x + 1, y], original[x - 1, y], original[x, y - 1], original[x + 1, y - 1], original[x - 1, y - 1] };
            }
            else if (x == 0)
                matrix = new double[6] { original[x, y], original[x, y + 1], original[x, y - 1], original[x + 1, y], original[x + 1, y + 1], original[x + 1, y - 1] };
            else if (x == original.GetLength(0) - 1)
                matrix = new double[6] { original[x, y], original[x, y + 1], original[x, y - 1], original[x - 1, y], original[x - 1, y + 1], original[x - 1, y - 1] };
            else 
                matrix = new double[9] { original[x, y], original[x + 1, y], original[x - 1, y],original[x, y - 1],
                    original[x + 1, y - 1], original[x - 1, y - 1], original[x, y + 1], original[x + 1, y + 1], original[x - 1, y + 1] };

            foreach (var e in matrix)
                resultPixel.Add(e); 
            resultPixel.Sort();
            if (resultPixel.Count == 9)
                median = (double)resultPixel[4];
            else
                median = ((double)resultPixel[(resultPixel.Count+1)/2] + (double)resultPixel[(resultPixel.Count+1)/2 -1])/2;
            return median;           
        }
	}
}
