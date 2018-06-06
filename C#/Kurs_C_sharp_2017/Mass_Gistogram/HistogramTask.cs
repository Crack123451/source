using System;

namespace Names
{
	internal static class HistogramTask
	{
		public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
		{
            double[] numbersPeople = new double[31];
            for (int i = 1; i < names.Length; i++)
            {
                if (names[i].Name == name && names[i].BirthDate.Day != 01)
                    numbersPeople[names[i].BirthDate.Day-1]++;
            }            
			return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), HistogramAxisX(), numbersPeople);
		}

        public static String[] HistogramAxisX()
        {
            String []dataMounth = new String[31];
            for(int i = 0; i<dataMounth.Length; i++)
                dataMounth[i] = (i+1).ToString();
            return dataMounth;
        }
    }
}