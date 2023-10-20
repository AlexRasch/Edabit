using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Domain;

namespace Tests
{
    internal class Test_Return_the_Middle_Character
    {

        /* 
         * Create a function that takes a string and returns the middle character(s). If the word's length is odd, 
         *  return the middle character. If the word's length is even, return the middle two characters.
         *  - All test cases contain a single word (as a string).
         *  - https://edabit.com/challenge/JF25KTZEcPzXhBvpM
         * 
         */

        [Theory]
        [TestCase("test", "es")]
        [TestCase("testing", "t")]
        [TestCase("middle", "dd")]
        [TestCase("A", "A")]
        [TestCase("inhabitant", "bi")]
        [TestCase("brown", "o")]
        [TestCase("pawn", "aw")]
        [TestCase("cabinet", "i")]
        [TestCase("fresh", "e")]
        [TestCase("shorts", "or")]
        public void Array_of_Multiples_Test(string input1, string shouldReturn)
        {
            Assert.That(Domain.Return_the_Middle_Character.GetMiddle(input1), Is.EqualTo(shouldReturn));   
        }
    }
}
