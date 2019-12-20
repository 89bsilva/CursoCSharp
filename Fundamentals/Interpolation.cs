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

            Console.WriteLine("The " + brand + " " + product + " costs R$" + price);
            Console.WriteLine("The {0} {1} costs R${2}", brand, product, price);
            Console.WriteLine($"The {brand} {product} costs R${price}");
        }
    }
}
