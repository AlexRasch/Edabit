using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class ReverseAndNot
    {
        public static string Go(int input)
        {
            // Reverse
            char[] firstPart = input.ToString().ToCharArray();
            Array.Reverse(firstPart);

            // Keep as it is
            char[] secPart = input.ToString().ToCharArray();

            // Create output string
            char[] output = new char[firstPart.Length * 2];
            for (int i = 0; i < firstPart.Length; i++)
            {
                output[i] = firstPart[i];
            }
            for (int i = 0; i < secPart.Length; i++)
            {
                output[i + secPart.Length] = secPart[i];
            }


            return new string(output);
        }
    }
}
