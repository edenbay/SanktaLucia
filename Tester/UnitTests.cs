using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgifter;

namespace Tester
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, "March")]
        [InlineData(12, "December")]
        [InlineData(6, "June")]
        [InlineData(11, "November")]
        public void MonthNameTest(int monthNumber, string expected)
        {
            string result = Program.MonthName(monthNumber);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 7200)]
        [InlineData(10, 36000)]
        [InlineData(24, 86400)]
        public void HowManySecondsTest(int hours, int expected)
        {
            int result = Program.HowManySeconds(hours);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(4, "4")]
        public void FizzBuzzTest(int number, string expected)
        {
            string result = Program.FizzBuzz(number);

            Assert.Equal(expected, result);
        }
    }
}
