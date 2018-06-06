using System.Collections.Generic;

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
        public static List<List<string>> ParseSentences(string text)
        {
            var words = new List<string>();
            var sentences = new List<List<string>>();
            string[] massSentences = text.Split(new char[] { '.', '!', '?', ';', ':', '(', ')' });
            for (int i = 0; i < massSentences.Length; i++)
            {
                massSentences[i] = massSentences[i].Trim(new char[] { ' ', '\r', '\n' });
                for (int j = 0, flagStart = 0, startIndex = 0, finalSymbol=0; j < massSentences[i].Length; j++)
                {
                    if ((char.IsLetter(massSentences[i][j]) || massSentences[i][j]=='\'') && massSentences[i][j] != ' ' && flagStart == 0)
                    {
                        startIndex = j;
                        flagStart = 1;
                    }
                    if ((!char.IsLetter(massSentences[i][j]) || j== massSentences[i].Length-1) && massSentences[i][j] != '\'' && flagStart == 1)
                    {
                        if (j == massSentences[i].Length - 1)
                            finalSymbol = 1;
                        words.Add(massSentences[i].Substring(startIndex, j - startIndex+finalSymbol).ToLower());
                        flagStart = 0;
                        finalSymbol = 0;
                    }
                }
                //WordsWithDot()
                DeleteStopWords(words);
                sentences.Add(words);               
                words = words.GetRange(0, 0);
            }
            var sentencesWithoutNull = DeleteNullSentence(sentences);
            return sentencesWithoutNull;
        }

        public static string[] SeparateSentences(string text, List<string> words, List<List<string>> sentences)
        {
            string[] totalMass = text.Split(new char[] { '.', '!', '?', ';', ':', '(', ')' });
            /*for (int i=0;i<totalMass.Length;i++)
            {
                if (totalMass[i].Substring(totalMass.Length-1-))
            }*/
            return totalMass;
        }

        public static void DeleteStopWords(List<string> words)
        {
            for (int i = 0; i < StopWords.Length; i++)
                while (words.IndexOf(StopWords[i]) != -1)
                    words.Remove(StopWords[i]);
        }

        public static List<List<string>> DeleteNullSentence(List<List<string>> sentences)
        {
            var newSentence = new List<List<string>>();
            foreach (var i in sentences)
            {
                if (i.Count != 0)
                    newSentence.Add(i);
            }
        return newSentence;
        }
    }
}