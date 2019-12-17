using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp
{
    public class ExerciseCenter
    {
        Dictionary<string, Action> Exercises;

        public ExerciseCenter(Dictionary<string, Action> exercises)
        {
            Exercises = exercises;
        }

        public void SelectAndExecute()
        {
            int i = 1;

            foreach (var exercise in Exercises)
            {
                Console.WriteLine("{0}) {1}", i, exercise.Key);
                i++;
            }

            Console.Write("Enter exercise number (otherwise the last one will be executed): ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValid = num > 0 && num <= Exercises.Count;
            num = numValid ? num - 1 : Exercises.Count - 1;

            string exerciseName = Exercises.ElementAt(num).Key;

            Console.Write("\nRunning exercise ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exerciseName);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", exerciseName.Length + 21)) + "\n");

            Action run = Exercises.ElementAt(num).Value;
            try
            {
                run();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Oops! Something is wrong: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
