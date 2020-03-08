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
                {"Primeiro Programa - Fundamentos", FirstProgram.Execute},
                {"Comentários - Fundamentos", Comments.Execute},
                {"Variáveis e Constantes - Fundamentos", VarAndConst.Execute},
                {"Inferência - Fundamentos", Inference.Execute},
                {"Interpolação - Fundamentos", Interpolation.Execute},
                {"Notação Ponto - Fundamentos", DotNotation.Execute},
                {"Ler Dados - Fundamentos", ReadData.Execute},
                {"Formatando Números - Fundamentos", FormattingNumber.Execute},
                {"Conversão - Fundamentos", Conversion.Execute},
                {"Operadores Aritméticos - Fundamentos", ArithmeticOperators.Execute},
                {"Operadores Relacionais - Fundamentos", RelationalOperators.Execute}, 
                {"Operadores Lógicos - Fundamentos", LogicalOperators.Execute}, 
                {"Operadores de Atribuição - Fundamentos", AssignmentOperators.Execute}, 
                {"Operadores Unários - Fundamentos", UnaryOperators.Execute}, 
                {"Operadores Ternários - Fundamentos", TernaryOperators.Execute}, 
            });
            exerciseCenter.SelectAndExecute();
        }
    }
}