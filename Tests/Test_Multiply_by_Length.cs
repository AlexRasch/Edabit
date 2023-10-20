using Microsoft.VisualStudio.TestPlatform.TestHost;
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

    internal class Test_Multiply_by_Length
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(new int[] { 2, 6,4,9}, new int[] { 8, 24, 16, 36 })]
        [TestCase(new int[] { 4, 1, 1 }, new int[] { 12, 3, 3 })]
        [TestCase(new int[] { 1, 0, 3, 3, 7, 2, 1 }, new int[] { 7, 0, 21, 21, 49, 14, 7 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void Multiply_by_Length_Test(int[] input, int[] shouldReturn)
        {
            Assert.AreEqual(Domain.Multiply_by_Length.MultiplyByLength(input), shouldReturn);
        }
    }
}
