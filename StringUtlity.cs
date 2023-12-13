using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_y_StringBuilder_12_11_Udemy
{
    public class StringUtlity
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' '); // con esto, creamos un array de las palabras de la oración.
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";

        }
    }
}
