using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_io2;

namespace TestProject
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            int result = StringCalculator.SumString("");
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("12,12", 24)]
        [InlineData("1,25",26)]
        [InlineData("225,100",325)]
        public void SingleNumberReturnsValue(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12", 24)]
        [InlineData("1\n25", 26)]
        [InlineData("225\n100", 325)]
        public void StringSumNewLine(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12,1", 25)]
        [InlineData("1,13\n25", 39)]
        [InlineData("0,1,2", 3)]
        public void StringSumNewLineOrComma(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12,-1", 25)]
        [InlineData("1,-13\n25", 39)]
        [InlineData("0,1,-2", 3)]
        public void NegativeValThrowsArgException(string str, int expectedValue)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.SumString(str));
        }

        [Theory]
        [InlineData("12\n12,1000", 1024)]
        [InlineData("1,1300\n25", 26)]
        [InlineData("0,1,2000", 1)]
        public void ShouldIgnoreGreaterThan1000(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("12\n12,1000", 1024)]
        [InlineData("1,1300\n25", 26)]
        [InlineData("0,1,2000", 1)]
        public void ShouldIgnoreGreaterThan1000(string str, int expectedValue)
        {
            int result = StringCalculator.SumString(str);
            Assert.Equal(expectedValue, result);
        }
    }
}
