using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise4
    {
        //Ex 4. Write a function that, given a string as input, returns a new string that reverses the characters of the input string. For example, if the input is “Apple”, the return string should be “elppA”. HINT: Remember that you can access the individual characters in a string by using an array-like index:
        //String str = “Hello!”;
        //char c = str[1];            // c will be equal to ‘e’.

        public static string userWord()
        {
            Console.Write("Please select a word: ->  ");
            string wordChoice = Console.ReadLine();
            return wordChoice;
        }
        public static int wordLength(string userWord)
        {
            int stringLength = userWord.Length;
            return stringLength;
           
        }
        public static void wordReversed(string userWord, int wordLength)
        {
            //    //char[] word = new char[wordLength];
            //    //for(int i = 0; i <  wordLength; ++i)
            //    //{
            //    //    word[i] = userWord[i];
            //    //}
            //    //Array.Reverse(word);
            //    //string rWord = new string(word);

            char[] word = new char[wordLength];
            for (int i = 0; i<wordLength; i++)
            {
                word[(wordLength - 1) - i] = userWord[i];
            }
            string rWord = new string(word);

            Console.WriteLine("Your word backwards is: {0}", rWord);

        }
        
        



    }
}
