using System;
using Xunit;

namespace ConsoleApp.XUnit.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 2, 4)]
        public void Add_ShouldAddToValues(int value1, int value2, int expected)
        {
            var _calc = new Calculator();
            Assert.Equal(expected, _calc.Add(value1, value2));
        }
    }






   
}
