using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Multiply_by_Length
    {
        public static int[] MultiplyByLength(int[] input)
        {
            // Create a new array with length equal to input array
            int[] output = new int[input.Length];
            int multiplyByLength = input.Length;

            // Multiply 
            for (int i = 0; i < multiplyByLength; i++)
            {
                output[i] = input[i] * multiplyByLength;
            }

            return output;
        }
    }
}
