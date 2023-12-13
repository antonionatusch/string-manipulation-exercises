using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_y_StringBuilder_12_11_Udemy
{
    public class StringDemo
    {
        public static void ShortStringDemo()
        {
            // ToLower : convierte todo a minúscula
            // ToUpper : convierte todo a mayúscula
            // Trim : Elimina todos los espacios en blanco
            // IndexOf y LastIndexOf: te saca el índice de ese carácter o string en concreto.
            // Substring(indiceDelComienzo): crea un substring a partir de un string principal y un índice especificado.
            // Substring(indiceDelComeinzo, length): lo mismo que el anterior pero de una longitud determinada.
            // Replace(stringOCharDestino, reemplazo): reemplaza un caracter o una cadena por el reemplazo deseado.
            // IsNullOrEmpty: valor boolenao para comparar.
            // str.Split(' '): crear un array los cuales están separados por el separador indicado.

            var fullName = "Antonio Natusch ";
            Console.WriteLine("Trim: '{0}' ", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}' ", fullName.Trim().ToUpper());

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            Console.WriteLine(fullName.Replace("Antonio", "Tony"));

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            var sentence = "This is going to be a really really really really long text. ";
            var summary = StringUtlity.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        } 
        
    }
}
