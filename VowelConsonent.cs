using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelConsonent
    {
        public static void CheckVowelConsonent()
        {
            Console.WriteLine("Enter any Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is a vowel");
            }
            else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch + " is a Constant");
            }
            else
            {
                Console.WriteLine("Enter the valid Character");
            }
        }

        }


    }

