using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_y_StringBuilder_12_11_Udemy
{
    public class StringBuilderDemo
    {
        public static void ShortStringBuilderDemo()
        {
            // StringBuilder Es un string mutable, o sea, se puede cambiar sobre la marcha.
            // No está optimizado para búsqueda, o sea, no tiene IndexOf, Contains, etc.
            // Tiene métodos de manipulación como Append, Insert, Remove, etc. que veremos a continuación.

            var builder = new StringBuilder("Hello World");

            // Append - con distintos overloads, el visto aquí agrega cierto caracter las veces que le indiquemos
            
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Título")
                .AppendLine()
                .Append('-', 10)

            // Replace - reemplaza un caracter indicado por otro.

                .Replace('-', '+')

            // Remove - empieza desde cierto índice y remueve n cantidad de caracters.

            
                .Remove(0, 10)

            // Insert - Se tiene que especificar un índice, y el segundo parámetro podría ser un nuevo string, por ejemplo.

                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("Primer caracter: " + builder[0]);

        }
    }
}
