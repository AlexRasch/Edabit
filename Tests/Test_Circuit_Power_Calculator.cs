using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Test_Circuit_Power_Calculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(230, 10, 2300)]
        [TestCase(110, 3, 330)]
        [TestCase(480, 20, 9600)]
        public void Circuit_Power_Calculator_Test(int voltage, int current, int shouldReturn)
        {
            // https://edabit.com/challenge/L2fwjYi9YixY8kJfK
            Assert.That(Domain.Circuit_Power_Calculator.CircuitPower(voltage, current), Is.EqualTo(shouldReturn));
        }
    }
}
