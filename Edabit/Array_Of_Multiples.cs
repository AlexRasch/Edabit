using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Array_Of_Multiples
    {

        public static int[] ArrayOfMultiples(int input1, int inputLength)
        {
            // Create a new array with the length equal to inputLength
            int[] output = new int[inputLength];

            // Multiply and fill out array
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = input1 * (i + 1);
            }

            return output;
        }

    }
}
