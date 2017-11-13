using System;
using System.Linq;

namespace Names
{
	internal static class HistogramTask
	{
		public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
		{
            /*
			Напишите код, готовящий данные для построения гистограммы 
			— количества людей в выборке c заданным именем в зависимости от числа (то есть номера дня в месяце) их рождения.
			Не учитывайте тех, кто родился 1 числа любого месяца.
			Если вас пугает незнакомое слово гистограмма — вам как обычно в википедию! 
			http://ru.wikipedia.org/wiki/%D0%93%D0%B8%D1%81%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B0

			В качестве подписей (label) по оси X используйте число месяца.

			Объясните наблюдаемый результат!

			Пример подготовки данных для гистограммы смотри в файле HistogramSample.cs
			*/
            String[] dataMounth = new String[31];
            for(int i = 0; i < dataMounth.Length; i++)
            {
                dataMounth[i] = (i+1).ToString();
            }

            String namesStr;
            double[] kolPeople = new double[31];
            for (int i = 1; i < names.Length; i++)
            {
                namesStr=names[i].ToString();
                if (namesStr.Substring(14) == name && namesStr.Substring(0, 2) != "01")
                    kolPeople[int.Parse(namesStr.Substring(0, 2))-1]++;
            }
            
			return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), dataMounth, kolPeople);
		}
	}
}