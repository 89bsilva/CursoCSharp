using System;

namespace CursoCSharp.Fundamentals
{
    class VarAndConst
    {
        public static void Execute()
        {
            //Circumference area

            double radius = 4.5;
            const double Pi = 3.14159265359;
            double area = Pi * radius * radius;

            Console.WriteLine("Circumference area is: " + area);
            Console.WriteLine("This is not a sum: " + area + 123456);
            Console.WriteLine("This is a sum: " + (area + 123456));

            //Internal Types

            bool itsRaining = false;
            Console.WriteLine("It's raining? " + itsRaining);

            byte age = 30; // byte only accepts positive integer numbers in the range 0 to 255
            Console.WriteLine("I have " + age + " years old");

            sbyte goalDifference = sbyte.MinValue + sbyte.MaxValue; // sbyte (signed byte) accepts integer numbers in the range -128 to 127
            Console.WriteLine("The goal difference is: " + goalDifference);

            short salary = short.MaxValue;
            Console.WriteLine("Today is payday and I received R$ " + salary);

            int smallestInValue = int.MinValue; // int is used most of integers | Accepts integer numbers in the range -2147483648 to 2147483647
            Console.WriteLine("This is smallest int value: " + smallestInValue);

            uint brazilianPopulation = 207_600_000; // uint (unsigned int) only accepts positive integer numbers in the range 0 to 4294967295
            Console.WriteLine("The brazilian population is: " + brazilianPopulation);

            long lowestLongValue = long.MinValue; //Accepts integer numbers in the range -9223372036854775808 to 9_223_372_036_854_775_807
            Console.WriteLine("The lowest LONG value is: " + lowestLongValue);

            ulong worldPopulation = 7_600_000_000; //Only accepts positive integer numbers in the range 0 to 18_446_744_073_709_551_615
            Console.WriteLine("The world population is " + worldPopulation);

            float macbookPrice = 5438.69F;
            Console.WriteLine("Macbook price is: " + macbookPrice);

            double appleMarketPrice = 1000000000000.01;
            Console.WriteLine("Apple market price is: " + appleMarketPrice); // double is native to the c# literal number and is the most commonly used

            decimal distanceBetweenStars = decimal.MaxValue; // Used for larger values
            Console.WriteLine("Distance between the stars is: " + distanceBetweenStars);

            char letter = 'b';
            Console.WriteLine("Letter: " + letter);

            string text = "This is the study of C# internal types.";
            Console.WriteLine(text);
        }
    }
}
