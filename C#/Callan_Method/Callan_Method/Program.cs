using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callan_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четные (нечетные) числа ОТ и ДО включительно (через Enter):");
            int start = Int32.Parse(Console.ReadLine());
            int finish = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= finish; i+=2)
            {
                sum++;
                if (i == finish)
                {
                    Console.Write(i);
                    break;
                }
                Console.Write("{0},", i);                
            }
            Console.WriteLine("Сумма страниц:");
            Console.WriteLine("\n\n"+sum);
            Console.ReadKey();
        }
    }
}
