using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Check
    {
        public static int IsPowerOfTwo(int num)
        {
            int power = 0, temp;
            temp = num;
            while (temp > 0 && temp % 2 == 0)
            {
                if (temp % 2 == 0 && temp / 2 == 1)
                {
                    return ++power;
                }

                temp = temp / 2;
                power++;
            }

            return 0;
        }

        public static bool IsBoolean(string input)
        {
            input.ToLower();
            ////this check the value of input if its true or false
            while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("You have not entered a boolean value please try again");
                input = Console.ReadLine();
            }

            return input.Equals("true") ? true : false;
        }
    }

}

