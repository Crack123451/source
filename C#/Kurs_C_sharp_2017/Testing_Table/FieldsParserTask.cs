using System;
using System.Collections.Generic;

namespace TableParser
{
	public class FieldsParserTask
	{
        static int flagQuotes = 0;
        static string lineWork = null;

        public static List<string> ParseLine(string line)
        {
            lineWork = line;
            flagQuotes = 0;
            List<string> list = new List<string>();
            if (String.IsNullOrWhiteSpace(lineWork))
               return list;
            else if (lineWork.IndexOf('\'') == -1 && lineWork.IndexOf('\"') == -1)
            {
                string[] lineMass = line.Trim().Split(' ');
                foreach (string e in lineMass)
                    list.Add(e);
                return list;
            }
            else
            {
                lineWork = lineWork.TrimStart(' ');
                int leinghtFeild;
                for (int i = 0; i < lineWork.Length; i=leinghtFeild+1)
                {
                    if (flagQuotes == 1) //Значит мы выводили поле ДО ковычки и нужно пройти ковычку
                    {
                        i++;
                    }
                    if(flagQuotes==-1)
                        i--; //Значит мы выводили поле непосредственно ПЕРЕД ковычкой
                    leinghtFeild = ReadField(lineWork, i).GetIndexNextToToken();
                    list.Add(line.Substring(ReadField(lineWork, i).StartIndex, ReadField(lineWork, i).Length));
                }
                return list;
            }
        }

        private static Token ReadField(string lineWork, int startIndex)
		{
            flagQuotes = 0;
            int indexQuoteSmall = lineWork.IndexOf('\'', startIndex);
            int indexQuoteBig = lineWork.IndexOf('\"', startIndex);

            for (int i=startIndex;i< lineWork.Length;i++)
            {
                if ((i + 1 == indexQuoteSmall || i + 1 == indexQuoteBig) && lineWork[i] != ' ' && i != indexQuoteSmall && i != indexQuoteBig)
                {
                    flagQuotes = -1;
                    return new Token(lineWork, startIndex, (i + 1) - startIndex);
                }
                else if (i == indexQuoteSmall)
                    return FieldInQuotes(lineWork, startIndex = i + 1, i + 1, '\'');
                else if (i == indexQuoteBig)
                    return FieldInQuotes(lineWork, startIndex = i + 1, i + 1, '\"');
                else if (lineWork[i] == ' ' && (i - 1 == indexQuoteSmall || i - 1 == indexQuoteBig)) { }
                else if (lineWork[i] == ' ' || i + 1 == indexQuoteSmall || i + 1 == indexQuoteBig)
                    return new Token(lineWork, startIndex, i - startIndex);
                else { }
            }
			return new Token(lineWork, startIndex-1, lineWork.Length+1-startIndex);
		}

        private static Token FieldInQuotes(string lineWork, int startIndex, int currentIndex, char quote)
        {
            flagQuotes = 1;
            for (; currentIndex < lineWork.Length; currentIndex++)
            {
                if (lineWork[currentIndex] == quote && lineWork[currentIndex - 1] != '\\')
                    break;
                if (lineWork[currentIndex] == '\\' && 
                        (lineWork[currentIndex + 1] == '\\' || lineWork[currentIndex + 1] == '\'' || lineWork[currentIndex + 1] == '\"'))
                {
                    lineWork = lineWork.Remove(currentIndex, 1);
                    continue;
                }               
            }
            return new Token(lineWork, startIndex, currentIndex - startIndex);
        }
    }
}