using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Prime
    {
        public static void CheckPrimeFactorial()
            
            {
                int n = 6;
                double fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("factorial of {0}={1}", n, fact);
                Console.ReadLine();
            }
        }
    }