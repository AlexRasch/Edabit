namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        public void Return_The_Sum_Of_Two_Number(int x, int y, int shouldReturn)
        {
            Assert.Equals(Sum(x, y), shouldReturn);
        }
    }
}