using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public  class HarmonicNo
    {
        public static void FindHarmonic()
        {
            double n = Convert.ToInt32(Console.ReadLine());
            double Harmonic = 1;

            for (float i = 0; i < n; i++)
            {
                Harmonic = Harmonic + 1 / i;
                Console.WriteLine(Harmonic);
            }
        }
    }
}
