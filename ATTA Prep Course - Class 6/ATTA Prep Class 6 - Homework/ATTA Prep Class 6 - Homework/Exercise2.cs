using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise2
    {

        /*Ex. 2. Write a function that, given two strings as input, determines how many times the second string appears as a substring of the first string. For example:
            Str1: “ababa”	Str2: “aba”	Result: 2
            Str1: “aabaab”	Str2: “ba”	Result: 1
            Str1: “abbab”	Str2: “ab”	Result: 2
            Str1: “aaaaa”	Str2: “ab”	Result: 0
            */

        public static string userString1;
        public static string userString2;


        public static void setStrings()
        {
            Console.Write("Please select your first string: ->   ");
            userString1 = Console.ReadLine();
            Console.Write("\nPlease select your second string: ->   ");
            userString2 = Console.ReadLine();
        }

        public static int frequencyCount(string s1, string s2)
        {
            bool test2 = false;
            int frequency = 0;
            for (int i = 0; i < s1.Length - 1; ++i)
            {
                if (s1[i] == s2[0])
                {
                    test2 = innerCount(s1, s2, i);
                    if (test2 == true)
                    {
                        ++frequency;
                    }
                    else
                    {
                        test2 = false;
                    }
                }
            }

            return frequency;
        }

        public static bool innerCount(string s1, string s2, int i)
        {
            bool test = false;
            for (int j = 1; j < s2.Length - 1; ++j)
            {
                if (s1[i + j] == s2[j])
                {
                    test = true;
                }
                else if (s1[i + j] != s2[j])
                {
                    test = false;
                    break;
                }
            }
            return test;
        }
    }
}
