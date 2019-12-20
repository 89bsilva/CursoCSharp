using System;

namespace CursoCSharp.Fundamentals
{
    class DotNotation
    {
        public static void Execute()
        {
            var salutation = "hello".ToUpper().Insert(5, " Mundo!").Replace("Mundo", "WORLD");
            Console.WriteLine(salutation);
            Console.WriteLine("test".Length);

            string importantValue = null;
            Console.WriteLine(importantValue?.Length); // Use "?" to secure navigation in dot notation
        }
    }
}
