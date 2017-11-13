using System;
using System.Collections;

namespace Recognizer
{
	public static class ThresholdFilterTask
	{
        /* 
		 * Замените пиксели ярче порогового значения T на белый (1.0),
		 * а остальные на черный (0.0).
		 * Пороговое значение найдите так, чтобы:
		 *  - если N — общее количество пикселей изображения, 
		 *    то хотя бы (int)(threshold*N)  пикселей стали белыми;
		 *  - белыми стало как можно меньше пикселей.
		*/
        public static double[,] ThresholdFilter(double[,] original, double threshold)
		{
            double thresholdValue=0;
            var listPixels = new ArrayList();
            foreach (var e in original)
                listPixels.Add(e);
            listPixels.Sort();

            int minNumberThresholdValue = (int)Math.Round(threshold * original.Length);
            for (int i = 0, j = 0; i < listPixels.Count; i++)
            {
                if ((double)listPixels[i] >= threshold)
                {
                    thresholdValue = (double)listPixels[i];
                    j++;
                }
                if (j == minNumberThresholdValue)
                    break;
            }

            var thresholdFilterResult = new double[original.GetLength(0),original.GetLength(1)];
            for (int i = 0; i < original.GetLength(0); i++)
                for (int j = 0; j < original.GetLength(1); j++)
                {
                    if (original[i, j] >= thresholdValue)
                        thresholdFilterResult[i, j] = 1.0;
                    else
                        thresholdFilterResult[i, j] = 0.0;
                }

			return thresholdFilterResult;
		}
	}
}