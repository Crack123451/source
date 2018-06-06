namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            count = 1;
            string num = count.ToString();
            if (num.Length == 1)
            {
                if (num[0] == '1')
                    return "рубль";
                else if ((num[0] == '2') || (num[0] == '3') || (num[0] == '4'))
                    return "рубля";
                else
                    return "рублей";
            }
            else {
                if (num[num.Length - 1] == '1' && (num[num.Length - 2] != '1'))
                    return "рубль";

                else if (((num[num.Length - 1] == '2') || (num[num.Length - 1] == '3') || (num[num.Length - 1] == '4')) && (num[num.Length - 2] != '1'))
                    return "рубля";

                else
                    return "рублей";
            }
        }
	}
}