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
            int index;
            double[] a = new double[3];
            for (int i = 0; i < 3; i++)
            {
                index = userInput.IndexOf(' ');
                if (index != -1)
                {
                    a[i] = double.Parse(userInput.Substring(0, index));
                    userInput = userInput.Substring(index + 1, userInput.Length - (index + 1));
                }
                else
                {
                    a[i] = double.Parse(userInput);
                    break;
                }

            }

            for (int i = 0; i < a[2]; i++)
                a[0] = a[0] + (a[1] * a[0] / (12*100));

            //Console.WriteLine(a[0]);
            //Console.ReadKey();
            return a[0];
        }

    }
}
