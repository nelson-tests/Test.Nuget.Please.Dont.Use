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
    }
}
