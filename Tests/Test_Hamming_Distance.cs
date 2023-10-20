using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Test_Hamming_Distance
    {
        /*
         *  Hamming distance is the number of characters that differ between two strings.
         * 
         *  - Both strings will have the same length.
         *  
         *  https://edabit.com/challenge/K49LXsoMmS6tXxP7R
         */

        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase("abcde", "bcdef", 5)]
        [TestCase("abcde", "abcde", 0)]
        [TestCase("strong", "strung", 1)]
        public void Hamming_Distance_Test(string input1, string input2, int shouldReturn)
        {
            // https://edabit.com/challenge/L2fwjYi9YixY8kJfK
            Assert.That(Domain.Hamming_Distance.HammingDistance(input1, input2), Is.EqualTo(shouldReturn));
        }
    }
}
