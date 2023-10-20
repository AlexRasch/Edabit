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
        public void Multiply_by_Length_Test(int[] input, int[] shouldReturn)
        {
            // Input
            int[] i1 = { 2, 6, 4, 9 };
            int[] i2 = { 4, 1, 1 };
            int[] i3 = { 1, 0, 3, 3, 7, 2, 1 };
            int[] i4 = { 0 };

            // Expected output
            int[] o1 = { 8, 24, 16, 36 };
            int[] o2 = { 12, 3, 3 };
            int[] o3 = { 7, 0, 21, 21, 49, 14, 7 };
            int[] o4 = { 0 };

            Assert.AreEqual(o1, Domain.Multiply_by_Length.MultiplyByLength(i1));
            Assert.AreEqual(o2, Domain.Multiply_by_Length.MultiplyByLength(i2));
            Assert.AreEqual(o3, Domain.Multiply_by_Length.MultiplyByLength(i3));
            Assert.AreEqual(o4, Domain.Multiply_by_Length.MultiplyByLength(i4));
        }
    }
}
