using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            Console.ReadKey();
        }
        private static void WriteTextWithBorder(string text)
        {
            PlusMinus(text);
            Console.WriteLine("\n| " + text + " |");
            PlusMinus(text);
        }
        private static void PlusMinus(string text)
        {
            for (int i = 0; i < text.Length + 4; i++)
            {
                if (i == 0 || i == text.Length + 3)
                    Console.Write("+");
                else
                    Console.Write("-");
            }
        }
    }
}
