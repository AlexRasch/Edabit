using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Test_Return_the_Next_Number_from_the_Integer_Passed
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(0, 1)]
        [TestCase(9, 10)]
        [TestCase(-3, -2)]
        public void Return_the_Next_Number_from_the_Integer_Passed_Test(int x, int shouldReturn)
        {
            // https://edabit.com/challenge/RzkLShpDgDqG3c45H
            Assert.That(Domain.Return_the_Next_Number_from_the_Integer_Passed.Addition(x), Is.EqualTo(shouldReturn));
        }
    }
}
