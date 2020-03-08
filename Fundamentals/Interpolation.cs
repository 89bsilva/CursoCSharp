using System;

namespace CursoCSharp.Fundamentals
{
    class Interpolation
    {
        public static void Execute()
        {
            string product = "Notebook";
            string brand = "Dell";
            double price = 5800.00;

            Console.WriteLine("O " + product + " " + brand + " custa R$" + price);
            Console.WriteLine("O {1} {0} custa R${2}", brand, product, price);
            Console.WriteLine($"O {product} {brand} custa R${price}");
        }
    }
}
