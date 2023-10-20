using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Convert_Number_to_Corresponding_Month_Name
    {
        private static Dictionary<int, string> months = new Dictionary<int, string>
        {
            {1, "January" },
            {2, "February" },
            {3, "March" },
            {4, "April" },
            {5, "May" },
            {6, "June" },
            {7, "July" },
            {8, "August" },
            {9, "September" },
            {10, "October" },
            {11, "November" },
            {12, "December" },
        };

        public static string MonthName(int month)
        {
            if(months.TryGetValue(month, out string outputMonth))
            {
                return outputMonth;
            }

            throw new Exception("Invalid input, needs to be valid int between 1 - 12");
        }


    }
}
