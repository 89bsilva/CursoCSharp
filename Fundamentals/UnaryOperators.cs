using System;

namespace CursoCSharp.Fundamentals
{
    class UnaryOperators
    {
        public static void Execute()
        {
            var negativeValue = -5;
            var num1 = 1;
            var num2 = 2;
            var boolean = true;

            Console.WriteLine(-negativeValue);
            Console.WriteLine(!boolean);

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2); // var num2 será decrementada antes da comparação e a var num1 será incrementada após a comparação
        }
    }
}
