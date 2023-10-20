using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Return_the_Middle_Character
    {
        public static string GetMiddle(string input)
        {
            int length = input.Length;
            if (length < 2)
                return input;

            int middle = length / 2;
            return (length % 2 == 0) ? input.Substring(middle - 1, 2) : input.Substring(middle, 1);
        }
    }
}
