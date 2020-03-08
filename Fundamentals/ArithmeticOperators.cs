using System;

namespace CursoCSharp.Fundamentals
{
    class ArithmeticOperators
    {
        public static void Execute()
        {
            var price = 930.50;
            var tax = 135;
            var discount = 0.1;
            var total = price + tax;
            var discountPrice = total - (total * discount);
            Console.WriteLine($"O preço final é {discountPrice}");

            //Índice de massa corporal
            double weight = 160;
            double height = 1.77;
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"Seu índice de massa corporal é: {bmi}");

            //Par / Ímpar
            int even = 10;
            int odd = 5;
            Console.WriteLine($"{even}/2 tem resto {even % 2}");
            Console.WriteLine($"{odd}/2 tem resto {odd % 2}");
        }
    }
}
