using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            /*
           Подготовьте данные для построения карты интенсивностей, у которой по оси X — число месяца, по Y — номер месяца, 
           а интенсивность точки (она отображается цветом и размером) обозначает количество рожденных людей в это число этого месяца.
           Не учитывайте людей, родившихся первого числа любого месяца.

           В качестве подписей (label) по X используйте число месяца. 
           Поскольку данные за первые числа месяца учитывать не нужно, то начинайте подписи со второго числа.
           В качестве подписей по Y используйте номер месяца (январь — 1, февраль — 2, ...).

           Таким образом, данные для карты интенсивностей должны быть в виде двумерного массива 30 на 12 —  от 2 до 31 числа и от января до декабря.
           */

            double[,] dayAndMounth = new double[30, 12];
            for (int i = 0; i < names.Length; i++)
                if (names[i].BirthDate.Day >= 2)
                    dayAndMounth[names[i].BirthDate.Day - 2, names[i].BirthDate.Month - 1]++;           
            string[] day = new string[dayAndMounth.GetLength(0)];
            string[] mount = new string[dayAndMounth.GetLength(1)];
            for (int i = 0, j = 0; j < dayAndMounth.GetLength(0); i++, j++)
            {
                day[j] = (i + 2).ToString();
                if (j < dayAndMounth.GetLength(1))
                    mount[j] = (i + 1).ToString();
            }
            return new HeatmapData("Пример карты интенсивностей", dayAndMounth, day, mount);
        }
    }
}
