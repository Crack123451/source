using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Find_Min
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
        }
        static object Min(Array array)
        {
            //if(array.Length==0) return null;
            //if(array.Length==1) return array[0];

            var min = (IComparable)array.GetValue(0);
            for (int i = 1; i < array.Length; i++)
            {
                if (min.CompareTo(array.GetValue(i)) == +1)
                    min = (IComparable)array.GetValue(i);
            }
            return min;
        }
    }
}
