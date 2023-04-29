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
    }
}
