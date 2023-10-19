using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Test_Convert_Minutes_Into_Seconds
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(5, 300)]
        [TestCase(3, 180)]
        [TestCase(2, 120)]
        public void Convert_Minutes_Into_Seconds_Test(int x, int shouldReturn)
        {
            // https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
            Assert.AreEqual(Domain.Convert_Minutes_Into_Seconds.Sum(x), shouldReturn);

        }
    }
}
