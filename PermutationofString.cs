﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class PermutationofString
    {
        public static void usingIterativeMethod(String str, int initialLength, int length)
        {
            if (initialLength == length)
                Console.WriteLine(str);
            else
            {
                for (int i = initialLength; i <= length; i++)
                {
                    str = swap(str, initialLength, i);
                    usingIterativeMethod(str, initialLength + 1, length);
                    str = swap(str, initialLength, i);
                }
            }
        }
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
