using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znakomstvo_Semenar5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int kol = 0;
            if ((b % 4 == 0 && b % 100 != 0) || (b % 400 == 0))
            {
                kol = 1;
                if ((b - a) > 3)
                    kol = kol + ((b - a) / 4);
            }
            else if ((((b-1) % 4 == 0 && (b-1) % 100 != 0) || ((b-1) % 400 == 0)) && (b-a>=1))
            {
                b = b - 1;
                kol = 1;
                if ((b - a) > 3)
                    kol = kol + ((b - a) / 4);
            }
            else if ((((b - 2) % 4 == 0 && (b - 2) % 100 != 0) || ((b - 2) % 400 == 0)) && (b - a >= 2))
            {
                b = b - 2;
                kol = 1;
                if ((b - a) > 3)
                    kol = kol + ((b - a) / 4);
            }
            else if ((((b - 3) % 4 == 0 && (b - 3) % 100 != 0) || ((b - 3) % 400 == 0)) && (b - a >= 3))
            {
                b = b - 3;
                kol = 1;
                if ((b - a) > 3)
                    kol = kol + ((b - a) / 4);
            }
            else
            {
                Console.WriteLine("Високосных нет");
                Console.ReadKey();
                Environment.Exit(0);
            }   

            Console.WriteLine("Количество високосных лет между этими датами: "+kol);
            Console.ReadKey();
        }
    }
}
