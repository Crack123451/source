using System;
using System.Collections;
using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		public static double[,] MedianFilter(double[,] original)
		{
            // original = new double[3, 3] { { 1,1,1 }, { 1, 1, 1 } , { 1, 1, 0 } };
            //original = new double[3, 3] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            //original = new double[3, 3] { { 1, 0, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            var originalframe = new double[original.GetLength(0)+2, original.GetLength(1)+2];
            for (int x = 0; x < original.GetLength(0); x++)
                for (int y = 0; y < original.GetLength(1); y++)
                    originalframe[x + 1, y + 1] = original[x, y];

            var resultFilter = new double[original.GetLength(0), original.GetLength(1)];
            for (int x = 0; x < original.GetLength(0); x++)
                for (int y = 0; y < original.GetLength(1); y++)
                    resultFilter[x, y] = ResultPixel(x, y, originalframe,original);
			return resultFilter; 
		}

        public static double ResultPixel(int x, int y, double[,] originalframe, double[,] original)
        {
            double median=0;
            double[] matrix;
            ArrayList resultPixel = new ArrayList();
            matrix = new double[9] { originalframe[x, y], originalframe[x + 1, y], originalframe[x+2, y],originalframe[x, y+1],
                originalframe[x + 1, y+1], originalframe[x+2, y+1], originalframe[x, y + 2], originalframe[x + 1, y + 2], originalframe[x+2, y + 2] };
            foreach (var e in matrix)
                resultPixel.Add(e); 
            resultPixel.Sort();

            int countNull = 8;
            if (original.GetLength(0)>=3 && original.GetLength(1)>=3)   //узнаем сколько нулей от рамки
            {
                countNull = 0;
                if (originalframe[x, y] == 0 && originalframe[x + 1, y] == 0 && originalframe[x + 2, y] == 0 && y==0)
                    countNull+=3;
                if (originalframe[x, y+2] == 0 && originalframe[x + 1, y+2] == 0 && originalframe[x + 2, y+2] == 0 && y== original.GetLength(1)-1)
                    countNull += 3;
                if (originalframe[x, y] == 0 && originalframe[x, y + 1] == 0 && originalframe[x, y + 2] == 0 && x==0)
                {
                    if (countNull == 3)
                        countNull += 2;
                    else countNull += 3;
                }
                if (originalframe[x+2, y] == 0 && originalframe[x + 2, y + 1] == 0 && originalframe[x + 2, y + 2] == 0 && x== original.GetLength(0)-1)
                {
                    if (countNull == 3)
                        countNull += 2;
                    else countNull += 3;
                }
            }

            while (true)   //Удаляем все не нужные нули 
            {
                if ((double)resultPixel[0] == 0 && resultPixel.Count>9-countNull)
                    resultPixel.RemoveAt(0);
                else break;
            }

            int indexMedian;
            if (resultPixel.Count % 2 == 0)
            {
                indexMedian = resultPixel.Count / 2;
                median = ((double)resultPixel[indexMedian] + (double)resultPixel[indexMedian-1])/2;
            }
            else
            {
                indexMedian = (resultPixel.Count - 1) / 2;
                median = (double)resultPixel[indexMedian];
            }            
            return median;           
        }    
    }
}