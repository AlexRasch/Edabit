using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    /*
     * 
     * Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. 
     * For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
     * 
     *  https://edabit.com/challenge/uevxL5FNM77otyo9Z
     * 
     */

    internal class Test_Convert_Number_to_Corresponding_Month_Name
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(3, "March")]
        [TestCase(12, "December")]
        [TestCase(6, "June")]
        public void Convert_Number_to_Corresponding_Month_Name_Test(int month, string shouldReturn)
        {
            // https://edabit.com/challenge/L2fwjYi9YixY8kJfK
            Assert.That(Domain.Convert_Number_to_Corresponding_Month_Name.MonthName(month), Is.EqualTo(shouldReturn));
        }
    }
}
