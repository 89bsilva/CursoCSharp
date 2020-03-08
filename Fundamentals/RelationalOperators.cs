using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentals
{
    class RelationalOperators
    {
        public static void Execute()
        {
            //double grade = 6.0;
            double passingScore = 7.0;

            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double grade);

            Console.WriteLine("Nota inválida? {0}", grade > 10.0);
            Console.WriteLine("Nota inválida? {0}", grade < 0.0);
            Console.WriteLine("Perfeito? {0}", grade == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", grade != 10.0);
            Console.WriteLine("Passou? {0}", grade >= passingScore);
            Console.WriteLine("Recuperação? {0}", grade < passingScore);
            Console.WriteLine("Reprovado? {0}", grade <= 3.0);
        }
    }
}
