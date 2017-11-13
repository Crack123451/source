using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ\n" +
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой\n" +
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть\n" +
                "если особенно упорно подойдешь к делу\n\n" +
                "будет Трудно конечнО\n" +
                "Код ведЬ не из простых\n" +
                "очень ХОРОШИЙ код\n" +
                "то у тебя все получится\n" +
                "и я буДу Писать тЕбЕ еще\n\n" +
                "чао";

            string[] lines = words.Split('\n');
            foreach (string e in lines)
                Console.WriteLine(e);

            Console.WriteLine(DecodeMessage(lines));

        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> list = new List<string>();
            string[] lines_up = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
                lines_up[i] = lines[i].ToUpper();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0, start=0; i < lines[i].Length; j++,start++)
                {
                    if (lines[i].Length == j)
                        break;
                    if ((lines[i][j] == ' ' && lines[i][j + 1] != ' ') || (start == 0 && lines[i][start]==lines_up[i][start]))
                    {
                        if (start == 0) j = -1; //start введен для проверки 1 символа в строке
                        lines[i] = lines[i].Substring(j + 1, lines[i].Length - (j + 1));
                        lines_up[i] = lines_up[i].Substring(j + 1, lines_up[i].Length - (j + 1));
                        j = -1; //так как мы обрезаем строку, необходимо на след. проходе начать с 1 символа
                        if (lines[i][0] == lines_up[i][0])
                            list.Insert(0, lines[i].Substring(0, lines[i].IndexOf(' ')));
                    }
                }
            }
            string itog=null;
            foreach (string e in list)
                itog = itog+" "+e;
            itog = itog.Substring(1, itog.Length - 1); //убираем первый пробел

            return itog;
        }
    }
}
