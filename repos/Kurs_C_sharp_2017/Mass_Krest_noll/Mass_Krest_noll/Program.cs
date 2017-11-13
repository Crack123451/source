using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass_Krest_noll
{
    class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Check("XXX OO. ...");
            Check("OXO XO. .XO");
            Check("OXO XOX OX.");
            Check("XOX OXO OXO");
            Check("... ... ...");
            Check("XXX OOO ...");
        }

        private static void Check(string description)
        {
            Console.WriteLine(description.Replace(" ", "\r\n"));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            for (int i = 0; i < Mark.GetLength(0); i++)
                for (int j = 0; j < Mark.GetLength(1); j++)
                    Console.Write(Mark[i, j]);
            Console.WriteLine();
        }

    }
}
