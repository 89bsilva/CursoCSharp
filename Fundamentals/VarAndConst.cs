using System;

namespace CursoCSharp.Fundamentals
{
    class VarAndConst
    {
        public static void Execute()
        {
            //Área da circunferência

            double radius = 4.5;
            const double Pi = 3.14159265359;
            double area = Pi * radius * radius;

            Console.WriteLine("A área da circunferência é: " + area);
            Console.WriteLine("Assim não soma: " + area + 123456);
            Console.WriteLine("Assim soma: " + (area + 123456));

            //Tipos Internos

            bool itsRaining = false;
            Console.WriteLine("Está chovendo? " + itsRaining);

            byte age = 30; // byte aceita apenas números inteiros positivos no intervalo de 0 a 255
            Console.WriteLine("Eu tenho " + age + " anos");

            sbyte goalDifference = sbyte.MinValue + sbyte.MaxValue; // sbyte (signed byte) aceita números inteiros no intervalo -128 a 127
            Console.WriteLine("O saldo de gol é de: " + goalDifference);

            short salary = short.MaxValue;
            Console.WriteLine("Hoje é dia de pagamento e recebi R$ " + salary);

            int smallestInValue = int.MinValue; // int é o mais usados para inteiros | Aceita números inteiros no intervalo -2147483648 a 2147483647
            Console.WriteLine("O menor valor int é: " + smallestInValue);

            uint brazilianPopulation = 207_600_000; // uint (unsigned int) aceita apenas números inteiros positivos no intervalo de 0 a 4294967295
            Console.WriteLine("A população do Brasil é: " + brazilianPopulation);

            long lowestLongValue = long.MinValue; //Aceita números inteiros no intervalo -9223372036854775808 a 9_223_372_036_854_775_807
            Console.WriteLine("O menor valor LONG é: " + lowestLongValue);

            ulong worldPopulation = 7_600_000_000; //Aceita apenas números inteiros positivos no intervalo de 0 a 18_446_744_073_709_551_615
            Console.WriteLine("A população do mundo é: " + worldPopulation);

            float macbookPrice = 5438.69F;
            Console.WriteLine("Macbook price is: " + macbookPrice);

            double appleMarketPrice = 1000000000000.01;
            Console.WriteLine("O preço de mercado da Apple é: " + appleMarketPrice); // double é o nativo do c# para números literais e é o tipo mais usado

            decimal distanceBetweenStars = decimal.MaxValue; // Usado para grandes maiores
            Console.WriteLine("A distância entre as estrelas é: " + distanceBetweenStars);

            char letter = 'b';
            Console.WriteLine("Letra: " + letter);

            string text = "Este é o estudo dos tipos internos de C#.";
            Console.WriteLine(text);
        }
    }
}
