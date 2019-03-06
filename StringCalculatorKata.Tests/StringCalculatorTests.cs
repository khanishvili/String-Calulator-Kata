using System;
using Xunit;
using String_Calulator_Kata;
namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
            var underTest = new StringCalculator();
            var result = underTest.Add("");
            Assert.Equal(-1, result);
        }
    }
}
