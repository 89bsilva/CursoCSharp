using System;
using System.Globalization;

namespace CursoCSharp.Fundamentals
{
    class ReadData
    {   
        public static void Execute()
        {
            Console.Write("Como você se chama? ");
            string name = Console.ReadLine();
            
            Console.Write("Qual sua idade? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Quanto é o seu salario? ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Por favor, insira seu salario novamente! "); //InvariantCulture = Ignora a configuração de idioma do sistema 
            double salary2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name} {age} {salary} {salary2}");
        }
    }
}
