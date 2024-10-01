using FluentAssertions;
using Xunit;

namespace Test.Nuget.Please.Dont.Use.Tests
{
    public class CalcTests
    {
        [Fact]
        public void FourAndFive_Sum_Nine()
        {
            // Arrange
            var calc = new Calc(4, 5);



            // Act
            var act = calc.Sum();


            // Assert
            act.Should().Be(9);
        }

        [Fact]
        public void NineAnd2_SubSeven()
        {
            // Arrange
            var calc = new Calc(9, 2);


            // Act
            var act = calc.Sub();


            // Assert
            act.Should().Be(7);
        }



        [Fact]
        public void Div_tests()
        {
            // Arrange
            var calc = new Calc(6, 2);


            // Act
            var act = calc.Div();


            // Assert
            act.Should().Be(3);
        }



        [Fact]
        public void Mult_tests()
        {
            // Arrange
            var calc = new Calc(6, 2);


            // Act
            var act = calc.Mult();


            // Assert
            act.Should().Be(12);
        }
    }
}
