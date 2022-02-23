using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public  class LeapYear
    {
        public static void CheckingLeapYear()
        {
            int num;
            Console.WriteLine("Enter the year");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num%4 ==0 && num%100 != 0) || (num%400 ==0))
            {
                Console.WriteLine("Given year is a leap Year");
            }

            else
            {
                Console.WriteLine("Given year is not a leap Year");
            }

        }
    }
}
