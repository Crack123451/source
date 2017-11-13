using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(GetPoweredArray(arrayToPower, 1));
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
        }

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = (int)Math.Pow(arr[i], power);
            return arr;
        }
        public static void PrintArray (int[] arr)
        {
            foreach (int e in arr)
                Console.Write(e +", ");
            Console.WriteLine();
        }
    }
}
