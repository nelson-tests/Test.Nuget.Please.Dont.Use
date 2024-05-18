using System;
using FluentAssertions;
using Xunit;

namespace Test.Nuget.Please.Dont.Use.Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            // Arrange && Act
            var act = MyTestClass.MyTestMethod(DateTime.UtcNow.Year);


            // Assert
            act.Should().StartWith("Hello World. Year: ");
        }

        [Fact]
        public void Test2()
        {
            // Arrange && Act
            var act = MyTestClass.Sum(2,5);


            // Assert
            act.Should().Be(7);
        }

        [Fact]
        public void Test2_3()
        {
            // Arrange && Act
            var act = MyTestClass.Sum(2, 5, 4);


            // Assert
            act.Should().Be(11);
        }

        [Fact]
        public void Test3()
        {
            // Arrange && Act
            var act = MyTestClass.Sub(2,5);


            // Assert
            act.Should().Be(-3);
        }

        [Fact]
        public void Test4()
        {
            // Arrange && Act
            var act = MyTestClass.Mult(2,5);


            // Assert
            act.Should().Be(10);
        }

        [Fact]
        public void Div_Int()
        {
            // Arrange && Act
            var act = MyTestClass.Div(10,5);


            // Assert
            act.Should().Be(2);
        }

        [Fact]
        public void Div_Double()
        {
            // Arrange && Act
            var act = MyTestClass.Div(10.0,5.0);


            // Assert
            act.Should().Be(2.0);
        }

        [Fact]
        public void Test6()
        {
            // Arrange && Act
            var act = MyTestClass.Pow(2,5);


            // Assert
            act.Should().Be(32);
        }
    }
}
