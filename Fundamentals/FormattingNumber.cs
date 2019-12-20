using System;
using System.Globalization;

namespace CursoCSharp.Fundamentals
{
    class FormattingNumber
    {
        public static void Execute()
        {
            double ethanolPrice = 3.909;
            Console.WriteLine(ethanolPrice.ToString("F1")); // One decimal place
            Console.WriteLine(ethanolPrice.ToString("#.#")); // One decimal place
            Console.WriteLine(ethanolPrice.ToString("F2")); // Two decimal places
            Console.WriteLine(ethanolPrice.ToString("#.##")); // Two decimal places
            Console.WriteLine(ethanolPrice.ToString("C")); // Currency with two decimal places (default)
            Console.WriteLine(ethanolPrice.ToString("C0")); // Currency without decimal place
            Console.WriteLine(ethanolPrice.ToString("C3")); // Currency with three decimal places
            Console.WriteLine(ethanolPrice.ToString("P")); // Multiply by one hundred and add the percent sign

            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(ethanolPrice.ToString("C", culture)); // Force use of culture info

            int integer = 0000001234;
            Console.WriteLine(integer.ToString());
            Console.WriteLine(integer.ToString("D5")); //If the converted value has fewer digits than specified, leading zeros are added
            Console.WriteLine(integer.ToString("D10"));
        }
    }
}
