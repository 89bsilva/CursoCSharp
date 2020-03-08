using System;

namespace CursoCSharp.Fundamentals
{
    class TernaryOperators
    {
        public static void Execute()
        {
            var grade = 7.0;
            string result = grade >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"O aluno foi: {result.ToUpper()}");
        } 
    }
}
