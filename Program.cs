using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentals;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var exerciseCenter = new ExerciseCenter(new Dictionary<string, Action>() {
                // Fundamentos
                {"First Program - Fundamentals", FirstProgram.Execute},
                {"Comments - Fundamentals", Comments.Execute},
                {"Variables and Constants - Fundamentals", VarAndConst.Execute},
            });
            exerciseCenter.SelectAndExecute();
        }
    }
}