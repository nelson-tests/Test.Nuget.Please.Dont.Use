using System;
using System.Collections.Generic;

namespace Test.Nuget.Please.Dont.Use
{
    public class Calc
    {
        private static readonly Dictionary<string, Func<int, int, int>> Operations =
            new()
            {
                ["add"] = (a, b) => a + b,
                ["sub"] = (a, b) => a - b,
                ["mul"] = (a, b) => a * b
            };

        public int Calculate(string operation, int a, int b)
        {
            return Operations.TryGetValue(operation, out var func)
                ? func(a, b)
                : 0;
        }

        public int Value1 { get; private set; }
        public int Value2 { get; private set; }


        public Calc(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int Sum() => Value1 + Value2;

        public int Sub() => Value1 - Value2;
        public double Div() => Value1 / Value2;
        public double Mult() => Value1 * Value2;
    }


}
