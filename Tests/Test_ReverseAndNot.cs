using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Domain;

namespace Tests
{
    internal class Test_ReverseAndNot
    {

        /* 
         * Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
         *  - i is a non-negative integer.
         *  - https://edabit.com/challenge/YGhgctqPsKQxQQCFS
         * 
         */


        [Theory]
        [TestCase(123, "321123")]
        [TestCase(123456789, "987654321123456789")]

        public void ReverseAndNot_Test(int input1, string shouldReturn)
        {
            Assert.That(Domain.ReverseAndNot.Go(input1) , Is.EquivalentTo(shouldReturn));   
        }
    }
}
