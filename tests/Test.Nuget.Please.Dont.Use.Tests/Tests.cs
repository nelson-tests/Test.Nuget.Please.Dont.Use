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
        public void Test5()
        {
            // Arrange && Act
            var act = MyTestClass.Div(10,5);


            // Assert
            act.Should().Be(2);
        }
    }
}
