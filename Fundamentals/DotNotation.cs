using System;

namespace CursoCSharp.Fundamentals
{
    class DotNotation
    {
        public static void Execute()
        {
            var salutation = "ola".ToUpper().Insert(3, " World!").Replace("World", "MUNDO");
            Console.WriteLine(salutation);
            Console.WriteLine("teste".Length);

            string importantValue = null;
            Console.WriteLine(importantValue?.Length); // Usar "?" para proteger a navegação na notação de ponto

        }
    }
}
