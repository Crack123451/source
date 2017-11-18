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
            var thresholdFilterResult = new double[original.GetLength(0), original.GetLength(1)];
            double thresholdValue = threshold;
            var listPixels = new ArrayList();
            foreach (var e in original)
                listPixels.Add(e);
            listPixels.Sort();

            int minNumberThresholdValue = (int)(threshold * original.Length);
            double minValueThreshold = (double)listPixels[minNumberThresholdValue-1];
            int NumberMinPx = 0;

            for (int i = minNumberThresholdValue-1; i >0; i--)
            {
                if ((double)listPixels[i] == minValueThreshold)
                    NumberMinPx++;
                else break;
            }

            int countCorrentMin = 0;
            int countForNumberMinPx = 0;
            for (int i = 0; i < original.GetLength(0); i++)
                for (int j = 0; j < original.GetLength(1); j++)
                {
                    if (countCorrentMin < minNumberThresholdValue)
                    {
                        thresholdFilterResult[i, j] = 1.0;
                        countCorrentMin++;
                    }
                    else if (countCorrentMin == minNumberThresholdValue)
                    {
                        if (countForNumberMinPx < NumberMinPx)
                        {
                            thresholdFilterResult[i, j] = 1.0;
                            countForNumberMinPx++;
                        }
                    }
                    else break;
                }


            return thresholdFilterResult;
        }
    }
}