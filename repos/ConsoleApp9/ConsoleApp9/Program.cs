using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static void Main()
        {
            Assert.
            Assert.AreEqual(0, FirstOrDefault(new int[0], x => true)); // default(int) == 0
            Assert.AreEqual(null, FirstOrDefault(new string[0], x => true)); // default(string) == null
            Assert.AreEqual(3, FirstOrDefault(new[] { 1, 2, 3 }, x => x > 2));
            Assert.AreEqual(3, FirstOrDefault(new[] { 3, 2, 1 }, x => x > 2));
            Assert.AreEqual(3, FirstOrDefault(new[] { 2, 3, 1 }, x => x > 2));
        }

        private static T FirstOrDefault<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            if (source.Length == 0)
                return default(T);
            return default(T);
        }
    }
}
