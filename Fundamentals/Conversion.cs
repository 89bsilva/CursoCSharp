using System;

namespace CursoCSharp.Fundamentals
{
    class Conversion
    {
        public static void Execute()
        {
            int intValue = 10;
            double doubleValue = intValue;
            Console.WriteLine($"Conversion int({intValue}) to double: {doubleValue}");

            double gradesDouble = 9.7;
            int gradesInt = (int) gradesDouble; //In this case, explicit conversion is required
            Console.WriteLine($"Conversion double({gradesDouble}) to int: {gradesInt}");

            string numberInString;
            int numberInInt;

            Console.Write("Enter your age: ");
            numberInString = Console.ReadLine();
            numberInInt = int.Parse(numberInString);
            Console.WriteLine($"Your age is: {numberInInt}");
            numberInInt = Convert.ToInt32(numberInString);
            Console.WriteLine($"Your age is: {numberInInt}");

            //Safer Conversion String to Int
            Console.Write("Enter one integer number: ");
            numberInString = Console.ReadLine();
            int.TryParse(numberInString, out numberInInt);
            Console.WriteLine($"{numberInInt} is the result of converting string({numberInString}) to type int");

            Console.Write("Enter one integer number: ");
            int.TryParse(Console.ReadLine(), out int number2InInt);
            Console.WriteLine($"{number2InInt} is the result of second convertion string to type int");
        }
    }
}
