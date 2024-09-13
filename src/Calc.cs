namespace Test.Nuget.Please.Dont.Use
{
    public class Calc
    {
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
    }
}
