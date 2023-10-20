using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Domain;

namespace Tests
{
    internal class Test_Array_of_Multiples
    {

        /* 
         * Create a function that takes two numbers as arguments (num, length) and 
         * returns an array of multiples of num until the array length reaches length.
         *  - Notice that num is also included in the returned array.
         *  - https://edabit.com/challenge/2QvnWexKoLfcJkSsc
         * 
         */


        [Theory]
        [TestCase(7, 5, new int[] { 7, 14, 21, 28, 35 })]
        [TestCase(12, 10, new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
        [TestCase(17, 7, new int[] { 17, 34, 51, 68, 85, 102, 119 })]
        [TestCase(630, 14, new int[] { 630, 1260, 1890, 2520, 3150, 3780, 4410, 5040, 5670, 6300, 6930, 7560, 8190, 8820 })]
        [TestCase(140, 3, new int[] { 140, 280, 420 })]
        [TestCase(7, 8, new int[] { 7, 14, 21, 28, 35, 42, 49, 56 })]
        [TestCase(11, 21, new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 187, 198, 209, 220, 231 })]
        public void Array_of_Multiples_Test(int input1, int input2, int[] shouldReturn)
        {
            Assert.That(Domain.Array_Of_Multiples.ArrayOfMultiples(input1, input2) , Is.EquivalentTo(shouldReturn));   
        }
    }
}
