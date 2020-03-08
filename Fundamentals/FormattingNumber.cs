using System;
using System.Globalization;

namespace CursoCSharp.Fundamentals
{
    class FormattingNumber
    {
        public static void Execute()
        {
            double ethanolPrice = 3.909;
            Console.WriteLine(ethanolPrice.ToString("F1")); // Uma casa decimal
            Console.WriteLine(ethanolPrice.ToString("#.#")); // Uma casa decimal
            Console.WriteLine(ethanolPrice.ToString("F2")); // Duas casas decimais
            Console.WriteLine(ethanolPrice.ToString("#.##")); // Duas casas decimais
            Console.WriteLine(ethanolPrice.ToString("C")); // Moeda com duas casas decimais (default)
            Console.WriteLine(ethanolPrice.ToString("C0")); // Moeda sem casa decimal
            Console.WriteLine(ethanolPrice.ToString("C3")); // Moeda com três casas decimais
            Console.WriteLine(ethanolPrice.ToString("P")); // Multiplique por cem e adicione o sinal de porcentagem

            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(ethanolPrice.ToString("C", culture)); // Força o uso da configuração de idioma passada como parâmetro para new CultureInfo()

            int integer = 0000001234;
            Console.WriteLine(integer.ToString());
            Console.WriteLine(integer.ToString("D5")); //Se o valor convertido tiver menos dígitos que o especificado, zeros à esquerda serão adicionados  
            Console.WriteLine(integer.ToString("D10"));
        }
    }
}
