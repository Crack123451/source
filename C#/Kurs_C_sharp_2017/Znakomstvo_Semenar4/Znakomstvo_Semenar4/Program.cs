using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znakomstvo_Semenar4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int kolvo_deliteli_prom = 0, kolvo_deliteli_itog = 0;
            for (int i = 2; i < num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int deliteli = i % j;
                    if (deliteli == 0)
                        kolvo_deliteli_prom++;
                }
                if (kolvo_deliteli_prom == 2)
                    kolvo_deliteli_itog++;
                kolvo_deliteli_prom = 0;
            }
            Console.WriteLine("Число простых чисел до выбранного вами числа: " + kolvo_deliteli_itog);
            Console.ReadKey();
        }
    }
}
