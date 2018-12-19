using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise4
    {
        //Ex. 4. Write a find-and-replace function which takes two strings and a character as input. The function should search the first string for all instances of the second string and, upon finding them, replace them with the character you provided. Return a new string with the completed replacements. Examples:

        //    Input: “Hello, I was looking for Han Solo.”,    “lo”,   ‘*’
        //    Output: “Hel*, I was *oking for Han So*.”

        //    Input: “I am smitten”,  “sm”,   ‘k’
        //    Output: “I am kitten”

        public static string mainString;
        public static string findString;
        public static char replaceChar;

        public static void getUserInput()
        {
            Console.Write("Please select your first string: ->   ");
            mainString = Console.ReadLine();
            Console.Write("\nPlease select your second string: ->   ");
            findString = Console.ReadLine();
            Console.Write("\nPlease select your second string: ->   ");
            replaceChar = Char.Parse(Console.ReadLine());
        }
        public static string findReplace(string sMain, string sFind, char cReplace)
        {
            StringBuilder toBeString = new StringBuilder();
                        
            for(int i = 0; i < sMain.Length; ++i)
            {
                if(sMain[i] != sFind[0])
                {
                    toBeString.Append(sMain[i]);
                }
                else if(sMain[i] == sFind[0])
                {
                    bool sSubTest = isSubstring(sMain, sFind, i);
                    if(sSubTest == true)
                    {
                       i = i + sFind.Length - 1;
                       toBeString.Append(cReplace);
                    }
                    else if(sSubTest == false)
                    {
                        toBeString.Append(sMain[i]);
                    }
                }
            }
  
            return toBeString.ToString();
        }
        public static bool isSubstring(string sMain, string sFind, int iOutter)
        {
                for (int j = 1; j < sFind.Length; ++j)
            {
                if (sMain[iOutter + j] != sFind[j])
                {
                    return false;

                }
                else if (sMain[iOutter + j] == sFind[j])
                {
                    continue;
                }

            }
            return true;
        }
        
    }   
}
