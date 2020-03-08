using System;

namespace CursoCSharp.Fundamentals
{
    class AssignmentOperators
    {
        public static void Execute()
        {
            var num1 = 1;
            Console.WriteLine(num1);

            num1 = 2;
            Console.WriteLine(num1);

            num1 += 3; // num1 = num1 + 3
            Console.WriteLine(num1);

            num1 -= 4; // num1 = num1 - 4
            Console.WriteLine(num1);

            num1 *= 5; // num1 = num1 * 5
            Console.WriteLine(num1);

            num1 /= 6; // num1 = num1 / 6
            Console.WriteLine(num1);

            num1++; // num1 = num1 + 1
            Console.WriteLine(num1);

            num1--; // num1 - 1
            Console.WriteLine(num1);

            // Atribuição por cópia de valor
            int a = 1;
            int b = a;
            Console.WriteLine(b);

            // Atribuição por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.name = "Maria";
            
            dynamic d = c;
            d.name = "Bruno";
            Console.WriteLine(c.name);
        }
    }
}
