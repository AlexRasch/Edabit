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
        [TestCase(310, 5)]
        [TestCase(300, 5)]
        [TestCase(180, 3)]
        [TestCase(120, 2)]
        public void Convert_Minutes_Into_Seconds_Test(int x, int shouldReturn)
        {
            // https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
            Assert.AreEqual(Domain.Convert_Minutes_Into_Seconds.Convert(x), shouldReturn);

        }
    }
}
