using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise2
    {

        //Ex 2. Write a function that, given an array of strings as input, prints out the length of each string. If you need help, do some research on strings to learn how to determine their length.
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
        static public void wordLength(string [] sAry)
        {
            foreach (string i in sAry)
            {
                int numLetter = i.Length;
                Console.WriteLine("{0} is {1} letters long.", i, numLetter);
            }

        }
        



    }
}
