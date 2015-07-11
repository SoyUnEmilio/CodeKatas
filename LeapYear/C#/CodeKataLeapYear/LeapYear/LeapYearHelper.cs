using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LeapYearHelper
    {
        public static bool IsLeapYear(int year)
        {
            if (!IsAtypicalCommonYear(year)) 
                return false;
            
            return year % 4 == 0;
        }

        private static bool IsAtypicalCommonYear(int year)
        {
            return year%100 == 0 && year%400 != 0;
        }
    }
}
