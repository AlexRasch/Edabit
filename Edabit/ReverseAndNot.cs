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
            // Linq
            //string inputStr = input.ToString();
            //string reversedStr = new string(inputStr.Reverse().ToArray());
            //return inputStr + reversedStr;
            
            // Convert to string
            string inputStr = input.ToString();
            int length = inputStr.Length;

            char[] output = new char[length * 2];

            // Create output
            for (int i = 0; i < length; i++)
            {
                char digit = inputStr[i];
                output[i] = digit;
                output[length * 2 - 1 - i] = digit;
            }

            return new string(output);
        }
    }
}
