using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Notes
{
    class Program
    {

        // ******* Class Vertex - shallow copy - only a references are copied *******
        // Normally you would want to define Classes inside of it's own file.
        //class Vertex
        //{

        //    public float x;
        //    public float y;
        //    public Vertex(float _x, float _y)
        //    {
        //        x = _x;
        //        y = _y;

        //    }
        //}


        //    static public void NegateVertex(Vertex v)
        //    {
        //        v.x *= -1f;
        //        v.y *= -1f;
        //    }
        

        // ****** Struct Vertex - deep copy - data and references are copied *******
        // Normally you would want to define Structs inside of it's own file. 
        // You can use the Create new Class file and just delete the class information to Struct.
        //struct Vertex
        //{

        //    public float x;
        //    public float y;
        //    public Vertex(float _x, float _y)
        //    {
        //        x = _x;
        //        y = _y;

        //    }
        //}

        //static void NegateVertex(Vertex v)
        //{
        //    v.x *= -1f;
        //    v.y *= -1f;
        //}

        public static string userWord()
        {
            Console.Write("Please select a word (no numbers, whitespace, or special characters): ->  ");
            string wordChoice = Console.ReadLine();
            return wordChoice;
        }
        public static int wordLength(string userWord)
        {
            int stringLength = userWord.Length;
            return stringLength;

        }
        public static bool isPalindrome(string userWord, int wordLength)
        {
            //char[] word = new char[wordLength];
            //for (int i = 0; i < wordLength; ++i)
            //{
            //    word[i] = userWord[i];
            //}
            //Array.Reverse(word);
            //string rWord = new string(word);
            //return userWord == rWord;

            char[] word = new char[wordLength];
            for (int i = 0; i < wordLength; i++)
            {
                word[(wordLength - 1) - i] = userWord[i];
            }
            string rWord = new string(word);
            return userWord == rWord;
        }

        public static void pruneList(List<int> list)
        {
            List<int> pruned = new List<int>();
            int iHigh = list.Max();
            int iLow = list.Min();
            for(int i = 0; i < list.Count; ++i)
                if((list[i] == iHigh) || (list[i] == iLow))
                {
                    list.Remove[i];
                }
            return List<int> pruned;
        }


        static void Main(string[] args)
        {
            // ****** Session 6: Problem Solving and Algorithm Building *******
            // The Algorithm Design Manual (or something like it)

            // Today - Review Data Types and Problem solving

            // - Warm-Up reference types and value types
            // - Problem Solving techniques
            // - Methodology
            // - Practice

            // As a Class you will get -2.-3
            // As a Struct you will get 2.3
            //Vertex vertex1 = new Vertex(2f, 3f);
            //NegateVertex(vertex1);
            //Console.WriteLine("({0}.{1})", vertex1.x, vertex1.y);
        
            // Value types are generally numeric types (int, float ect.), Boolean Valuew, and user defined structs.

            // Problem Solving:
            // - Under the problem before you try to solve it.
            // - Plan before you code: use diagrams, step by step description, sudo code, or anything else that helps you clearify your approach.
            // - Break complex tasks into simplar ones. 
            // - Plan with concrete examples in mind.
            // - Extreme cases can be useful; the simplest case is almost always easier to reason about than the most complext case. 
            
            // Methodology
            // - Step 1: Understand your problem
            // - Step 2: Plan your solution
            // - Step 3: Translate your solution to language features.
            // - Step 4: Write the code.
            // - Step 5: Test, keeping edge cases in mind.
            // - Step 6: Revise and repeat.

            // Exercise #3:
            // Write a function that, give a string, returns true if the string is a palindrome and false if otherwise. Assume the impute will be all lowercase, no whitespace, no special characters.
            //string testWord = userWord();
            //int numLetters = wordLength(testWord);
            //bool palindromeCheck = isPalindrome(testWord, numLetters);
            //Console.WriteLine("{0} is a palindrome: {1}", testWord, palindromeCheck);

            // Group Exercise:
            // 1 - Write a program that, give a list<int> as input, removes the highest and lowest integers from the list. If there are not duplicate highs or lows, remove them all.
            // 2 - Write a program that, give two strings as input, finds and returns the total number of times that the second string occurs with in the first string. Assume that both strings are non-empty. Challenge mode: Do not solve this problem with regEX!
            // 3 - Write a program that, given an integer as input, returns a list<int> of all the distinct prime factors of the input integer.


            
        }
    }
}
