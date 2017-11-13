using System;
using System.Collections.Generic;
using System.Text;

namespace TableParser
{
	public class FieldsParserTask
	{
        public static List<string> ParseLine(string line)
        {
            var stringBuilder = new StringBuilder();
            var list = new List<string>();
            if (String.IsNullOrWhiteSpace(line))
               return list;
            else if (line.IndexOf('\'') == -1 || line.IndexOf('\"') == -1)
            {
                string[] lineMass = line.Trim().Split(' ');
                foreach (string e in lineMass)
                    list.Add(e);
                return list;
            }
            else
            {
                line = line.TrimStart(' ');
                int leinghtFeild;
                for (int i = 0; i < line.Length; i=leinghtFeild+1)
                {
                    leinghtFeild = ReadField(line, i).GetIndexNextToToken();
                    list.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                }
                return list;
            }
        }

        private static Token ReadField(string line, int startIndex)
        {
            int indexQuoteOne=line.IndexOf('\');

            for (int i = startIndex; i < line.Length; i++)
            {
                if(line[i]=='\')
            }
        }
    }
}