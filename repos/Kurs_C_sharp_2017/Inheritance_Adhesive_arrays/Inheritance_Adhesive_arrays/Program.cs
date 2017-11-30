using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Adhesive_arrays
{
    class Program
    {
        public static void Main()
        {
            var ints = new[] { 1, 2, 3 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        static Array Combine(params Array[] arrays)
        {
            if (arrays.Length == 0) return null;
            int summaryLength = 0;
            var elementType = arrays[0].GetType().GetElementType();
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i].GetType().GetElementType() != elementType)
                    return null;
                summaryLength += arrays[i].Length;
            }
            var result = Array.CreateInstance(elementType, summaryLength);
            for (int i = 0; i < arrays.Length; i++)
                for (int j = 0; j < arrays[i].Length; j++)
                    result.SetValue(arrays[i],j);
            return result;
        }

    }
}
