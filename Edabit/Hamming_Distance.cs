using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Hamming_Distance
    {
        public static int HammingDistance(string input1, string input2)
        {
            if (input1.Length != input2.Length)
                throw new Exception("Input does not have equal length");

            int difference = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] != input2[i])
                    difference++;
            }         

            return difference;
        }
    }
}
