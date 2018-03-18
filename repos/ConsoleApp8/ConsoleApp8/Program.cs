using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {        
        public static void Main()
        {
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));
        }

        static T Max<T>(T[] source)
            where T : IComparable
        {
            if (source.Length == 0)
                return default(T);
            T max = source[0];
            for (int i = 1; i < source.Length; i++)
            {
                if (max.CompareTo(source[i]) < 0)
                    max = source[i];
            }
            return max;
        }

    }
}
