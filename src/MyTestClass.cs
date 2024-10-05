using System;

namespace Test.Nuget.Please.Dont.Use
{
    public static class MyTestClass
    {
        public static string MyTestMethod(int year) => $"Hello World. Year: {year}";
        public static string YourTestMethod(string name) => $"Hello {name}.";
        public static string Welcome() => $"Welcome!!!!!!!";
        public static string WeTestMethod(string we) => $"We are {we}.";

        public static int Sum(int a, int b) => a + b;
        public static int Sum(int a, int b, int c) => a + b + c;
        public static int Sum(int a, int b, int c, int d) => a + b + c + d;
        public static int Sum(int a, int b, int c, int d, int e) => a + b + c + d + e;

        public static int Sub(int a, int b) => a - b;

        public static int Mult(int a, int b) => a * b;
        public static int Div(int a, int b) => a / b;

        public static double Pow(double a, double b) => Math.Pow(a, b);
    }
}
