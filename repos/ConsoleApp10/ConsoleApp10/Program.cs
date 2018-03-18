using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main()
        {
            // Функция тестирования ParsePoints

            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);

        }

        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            return lines
                .Select(l=>l.Split(' '))
                .Select(l => int.Parse(l[0]) & int.Parse(l[1]) )
                .ToList;
        }             
    }
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X, Y;
    }
}
