using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise6
    {
        //Ex. 6. Write a function that takes a string as input and returns a new string with the following properties:
        //    1.	Contains no non-alphabetic characters, including numbers and whitespace.
        //    2.	Converts all alphabetic characters to upper case.
        //    3.	Contains no duplicate characters.
        //    4.	Arranges all characters in alphabetical order.

        //    Examples:
        //    Input: “Sandwich!”
        //    Output: “ACDHINSW”
        //    Input “No, really?!?”
        //    Output: “AELNORY”
        //    Input: “The quick brown fox jumps over the lazy dog…”
        //    Output: “ABCDEFGHIJKLMNOPQRSTUVWYZ”

        static public string getInput()
        {
            Console.Write("Please enter a string:  ->  ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        static public string allTheThings(string uInput)
        {
            List<char> stringList = new List<char>();
            string inputToUpper = uInput.ToUpper();
            foreach (char c in inputToUpper)
            {
                if (Char.IsLetter(c))
                {
                    if (stringList.Contains(c))
                    {
                        continue;
                    }
                    else
                    {
                        stringList.Add(c);
                    }
                }
            }
            stringList.Sort();
            StringBuilder finalized = new StringBuilder();
            foreach (char d in stringList)
            {
                finalized.Append(d);
            }
            return finalized.ToString();
            
        }

    }
}
