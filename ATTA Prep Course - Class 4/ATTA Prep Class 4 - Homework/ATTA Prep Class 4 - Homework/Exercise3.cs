using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise3
    {
        //Ex 3. Modify the function in Ex. 2 to return the length of the longest string (or strings, it there are ties) in the array.

        static public string[] sArray = new string[5];

        static public void addElement()
        {
            Console.WriteLine("Please enter {0} words (you must hit enter after every word).", sArray.Length);
            for (int i = 0; i < sArray.Length; ++i)
            {
                string userInput = Console.ReadLine();
                sArray[i] = userInput;
            }
        }
        static public int longestWord(string[] sAry)
        {
            int longest = 0;
            foreach (string i in sAry)
            {
                int numLetter = i.Length;
                if(numLetter > longest)
                {
                    longest = numLetter;
                }
            }
            return longest;
        }


    }
}
