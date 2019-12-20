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
                // Fundamentals
                {"First Program - Fundamentals", FirstProgram.Execute},
                {"Comments - Fundamentals", Comments.Execute},
                {"Variables and Constants - Fundamentals", VarAndConst.Execute},
                {"Inference - Fundamentals", Inference.Execute},
                {"Interpolation - Fundamentals", Interpolation.Execute},
                {"Dot Notation - Fundamentals", DotNotation.Execute},
                {"Read Data - Fundamentals", ReadData.Execute},
                {"Formatting Number - Fundamentals", FormattingNumber.Execute},
                {"Conversion - Fundamentals", Conversion.Execute},
            });
            exerciseCenter.SelectAndExecute();
        }
    }
}