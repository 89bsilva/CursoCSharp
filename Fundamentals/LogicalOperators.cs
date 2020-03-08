using System;

namespace CursoCSharp.Fundamentals
{
    class LogicalOperators
    {
        public static void Execute()
        {
            bool work1 = true;
            bool work2 = false;

            bool tv50 = work1 && work2;
            Console.WriteLine($"Comprou a Tv de 50? {tv50}");

            bool tv32 = work1 ^ work2;
            Console.WriteLine($"Comprou a Tv de 32? {tv32}");

            bool iceCream = work1 || work2;
            Console.WriteLine($"Tomou sorvete? {iceCream}");
            Console.WriteLine($"Mais saudável? {!iceCream}");
        }
    }
}