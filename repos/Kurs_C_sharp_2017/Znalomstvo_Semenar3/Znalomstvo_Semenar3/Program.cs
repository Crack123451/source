using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalomstvo_Semenar3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 12)
                a = a - 12;
            a = 360 / 12 * a;
            Console.WriteLine("Угол равен: " + a);
            Console.ReadKey();
        }
    }
}
