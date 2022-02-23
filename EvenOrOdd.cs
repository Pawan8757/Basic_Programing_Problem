using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenOrOdd
    {
        public static void DeterminingEvenOrOdd()
        {

            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
                Console.WriteLine(number + " is even");
            else
                Console.WriteLine(number + " is odd ");


        }
    }
}
