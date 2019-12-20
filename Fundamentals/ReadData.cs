using System;
using System.Globalization;

namespace CursoCSharp.Fundamentals
{
    class ReadData
    {   
        public static void Execute()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("How much is your salary? ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Please enter your salary again! "); //InvariantCulture = Ignoring system language setting 
            double salary2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name} {age} {salary} {salary2}");
        }
    }
}
