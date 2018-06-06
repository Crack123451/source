using System;
using System.Collections.Generic;
using System.IO;

namespace TextAnalysis
{
	static class SentencesParserTask
	{
		public static readonly string[] StopWords =
		{
			"the", "and", "to", "a", "of", "in", "on", "at", "that",
			"as", "but", "with", "out", "for", "up", "one", "from", "into"
		};

        /*
		Разбейте файл с текстом на предложения и слова. 
		Считайте, что слова могут состоять только из букв (используйте метод char.IsLetter) или символа апострофа ',
		а предложения разделены одним из следующих символов .!?;:()
		Слова могут быть разделены любыми символами, за исключением тех, которые разделяют предложения.
		Удалите из текста слова, содержащиеся в массиве StopWords (частые незначащие слова при анализе текстов называют стоп-словами)
		Метод должен возвращать список предложений, где каждое предложение — это список оставшихся слов в нижнем регистре.
		*/

        static int countSentenceInlist = -1;

        public static List<List<string>> ParseSentences(string text)
        {
            string[] allStr = File.ReadAllLines("HarryPotterText.txt");
            List<List<string>> list = new List<List<string>>();
            SentenceInList(allStr, list);
            WordsInList(list);
            Console.ReadKey();
            return list;
        }

        public static List<List<string>> SentenceInList(string[] allStr, List<List<string>> list)
        {
            int endSentence;
            for (int i = 0; i < allStr.Length; i++)
                if (!String.IsNullOrWhiteSpace(allStr[i]))
                    for (int j = 0; j < allStr[i].Length; j++)
                        if (char.IsLetter(allStr[i][j]))
                        {
                            endSentence = allStr[i].IndexOfAny(new char[] { '.', '!', '?', ';', ':', '(', ')' }, j);
                            if (endSentence != -1)
                            {
                                countSentenceInlist++;
                                list.Add(new List<string>() { allStr[i].Substring(j, endSentence - j) });
                                j = endSentence;
                            }
                            else
                            {
                                countSentenceInlist++;
                                list.Add(new List<string>() {allStr[i].Substring(j, allStr[i].Length - j)}); 
                                break;
                            }
                        }
            return list;
        }

        public static List<List<string>> WordsInList(List<List<string>> list)
        {
            int numberWord = -1;
            for (int i = 0; i < countSentenceInlist; i++)
                for (int j = 0; j < list[countSentenceInlist][j].Length; j++)
                {
                    if (list[countSentenceInlist][j] == " ")
                    {
                        numberWord++;
                        //list[countSentenceInlist][numberWord];
                    }
                }
            return list;
        }
    }
}


