using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshibki_Procent
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(Console.ReadLine());
        }

        public static double Calculate(string userInput)
        {
            var a = new string[3];
            a = userInput.Split(' ');
            return ApplicationOfFormula(double.Parse(a[0]), double.Parse(a[1]), double.Parse(a[2]));
        }
        public static double ApplicationOfFormula(double sum, double procentMonth, double periodMonth)
        {
            for (int i = 0; i < periodMonth; i++)
                sum += procentMonth / 1200 * sum;
            return sum;
        }
    }
}
