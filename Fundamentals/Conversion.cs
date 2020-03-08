using System;

namespace CursoCSharp.Fundamentals
{
    class Conversion
    {
        public static void Execute()
        {
            int intValue = 10;
            double doubleValue = intValue;
            Console.WriteLine($"Convertendo int({intValue}) para double: {doubleValue}");

            double gradesDouble = 9.7;
            int gradesInt = (int) gradesDouble; //Nesse caso, a conversão explícita é necessária
            Console.WriteLine($"Convertendo double({gradesDouble}) para int: {gradesInt}");

            string numberInString;
            int numberInInt;

            Console.Write("Digite sua idade: ");
            numberInString = Console.ReadLine();
            numberInInt = int.Parse(numberInString);
            Console.WriteLine($"Você tem: {numberInInt} anos");
            numberInInt = Convert.ToInt32(numberInString);
            Console.WriteLine($"Você tem: {numberInInt} anos");

            //Conversão segura de String para Int
            Console.Write("Digite um número inteiro: ");
            numberInString = Console.ReadLine();
            int.TryParse(numberInString, out numberInInt);
            Console.WriteLine($"{numberInInt} é o resultado da conversão da string({numberInString}) para tipo int");

            Console.Write("Digite um número inteiro: ");
            int.TryParse(Console.ReadLine(), out int number2InInt);
            Console.WriteLine($"{number2InInt} é o resultado da segunda conversão do tipo string para o tipo int");
        }
    }
}
