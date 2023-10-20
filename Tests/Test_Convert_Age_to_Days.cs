using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    /*
     * 
     * - Use 365 days as the length of a year for this challenge.
     * - Ignore leap years and days between last birthday and now.
     * - Expect only positive integer inputs.
     * 
     *  https://edabit.com/challenge/nkkKguC5TgWnBiMLA
     * 
     */

    internal class Test_Convert_Age_to_Days
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(65, 23725)]
        [TestCase(0, 0)]
        [TestCase(20, 7300)]
        public void Circuit_Power_Calculator_Test(int year, int shouldReturn)
        {
            // https://edabit.com/challenge/L2fwjYi9YixY8kJfK
            Assert.That(Domain.Convert_Age_to_Days.CalcAge(year), Is.EqualTo(shouldReturn));
        }
    }
}
