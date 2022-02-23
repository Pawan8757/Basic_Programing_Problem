using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PowerOfTwo
    {
        public static void CalculatingPowerOfATwo()
        {
            int n = 4, y = 2, x = 1;

            for (int i = 0; i < n; i++)
            {
                x=x*y;

            }
            Console.WriteLine(x);
        }
    }
}
