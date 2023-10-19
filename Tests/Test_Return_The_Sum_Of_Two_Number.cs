using Domain;

namespace Tests
{
    public class Tests_Return_The_Sum_Of_Two_Number
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(3, 2, 5)]
        [TestCase(-3, -6, -9)]
        [TestCase(7, 3, 10)]
        public void Return_The_Sum_Of_Two_Number_Test(int x, int y, int shouldReturn)
        {
            // https://edabit.com/challenge/xfRucdwGksiyjZq4K
            Assert.AreEqual(Domain.Return_The_Sum_Of_Two_Numbers.Sum(x, y), shouldReturn);
            
        }
    }
}