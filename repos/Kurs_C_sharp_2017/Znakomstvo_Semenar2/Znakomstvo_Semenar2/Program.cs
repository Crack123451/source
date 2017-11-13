using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znakomstvo_Semenar2
{
    class Program
    {
        static void Main(string[] args)
        {
            String num = Console.ReadLine();
            Console.WriteLine(num.Substring(2,1) + num.Substring(1,1) + num.Substring(0,1));
            Console.ReadKey();


        }
    }
}
