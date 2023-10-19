namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(3, 2, 5)]
        [TestCase(-3, 6, -9)]
        [TestCase(7, 3, 10)]
        public void Return_The_Sum_Of_Two_Number(int x, int y, int shouldReturn)
        {
            // https://edabit.com/challenge/xfRucdwGksiyjZq4K
            Assert.Equals(Sum(x, y), shouldReturn);
        }
    }
}