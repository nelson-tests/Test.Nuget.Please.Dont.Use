namespace Test.Nuget.Please.Dont.Use
{
    public class Promo
    {
        public int Age { get; private set; }

        public Promo(int age)
            => Age = age;

        public bool Apply()
            => Age >= 18;

        public bool IsSenior()
            => Age >= 67;
    }
}

