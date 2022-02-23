using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Remainder
    {
        public static void FindingQuotientRemainder()
        {
            int dividend = 50; 
            int divisor = 8;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0}, Divisor: {1}");
            Console.WriteLine("Quotient = " +quotient);
            Console.WriteLine("Remainder = "+remainder);
        }
    }
}
