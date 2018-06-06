using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znakomstvo_semenar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a="+a + "\nb=" + b);
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("\na=" + a + "\nb=" + b);
            Console.ReadLine();
        }
    }
}
