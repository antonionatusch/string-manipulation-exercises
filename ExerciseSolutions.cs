using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_y_StringBuilder_12_11_Udemy
{
    public class ExerciseSolutions
    {
        public static void Exercise1()
        {
            Console.WriteLine("Digite una serie de números separados por un guión \"-\"");
            var userResponse = Console.ReadLine();

            if (String.IsNullOrEmpty(userResponse))
            {
                return;
            }

            var numbersFromUser = new List<int>();
            foreach(var number in userResponse.Split('-'))
                numbersFromUser.Add(Convert.ToInt32(number));

            numbersFromUser.Sort();

            var isConsecutive = true;

            for(int i = 1; i <  numbersFromUser.Count; i++)
            {
                if (numbersFromUser[i] != numbersFromUser[i-1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutivo" : "No consecutivo";

            Console.WriteLine(message);
        }
        public static void Exercise2() 
        {
            Console.WriteLine("Digite una serie de números separados por un guión \"-\"");
            var userResponse = Console.ReadLine();

            if(String.IsNullOrEmpty(userResponse))
            {
                return;
            }

            var numbersFromUser = new List<int>();
            foreach (var number in userResponse.Split('-'))
                numbersFromUser.Add(Convert.ToInt32(number));

            var uniqueNumbers = new List<int>(); 
            var isDuplicateFound = false;

            foreach(var number in numbersFromUser)
            {
                if (uniqueNumbers.Contains(number))
                {
                    isDuplicateFound = true;
                    break;
                }
                uniqueNumbers.Add(number);
            }

            var message = isDuplicateFound ? "Duplicate" : string.Empty;
            Console.WriteLine(message);


        }
        public static void Exercise3() 
        {
            Console.WriteLine("Digite una hora en el formato de 24 horas.");
            var userResponse = Console.ReadLine();

            if(String.IsNullOrEmpty(userResponse))
            {
                Console.WriteLine("Tiempo no válido.");
                return;
            }

            var responseAsTime = userResponse.Split(':');

            if(responseAsTime.Length != 2) 
            {
                Console.WriteLine("Tiempo no válido.");
                return;
            }

            var hoursFromResponse = Convert.ToInt32(responseAsTime[0]);
            var minutesFromResponse = Convert.ToInt32(responseAsTime[1]);

            if (hoursFromResponse >= 0 && hoursFromResponse <= 23 && minutesFromResponse >= 0 && minutesFromResponse <= 59)
            {
                Console.WriteLine("Ok");
            }
            else Console.WriteLine("Tiempo no válido");

        }
        public static void Exercise4() 
        {
            Console.WriteLine("Escribe unas cuantas palabras para convertirlas en PascalCase: ");
            var userResponse = Console.ReadLine();

            if(String.IsNullOrEmpty(userResponse))
            {
                return;
            }

            var responseToConvert = userResponse.Split(" ");
            var responseInPascal = "";
            foreach(var responseWord in responseToConvert)
            {
                var wordWithPascalCase = char.ToUpper(responseWord[0]) + responseWord.ToLower().Substring(1);
                responseInPascal += wordWithPascalCase;
            }
            Console.WriteLine(responseInPascal);



        }
        public static void Exercise5() 
        {
            Console.WriteLine("Escriba una palabra en inglés: ");
            var userResponse = Console.ReadLine().ToLower();
            var englishVowels = new [] { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;

            foreach(var letter in userResponse)
            {
                if(englishVowels.Contains(letter)) vowelsCount++;
            }

            Console.WriteLine(vowelsCount);

        }

    }
}
