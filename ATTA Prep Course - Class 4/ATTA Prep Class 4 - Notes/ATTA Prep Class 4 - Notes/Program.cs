using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Notes
{
    class Program
    {
        static void FirstLetters(string[] sAry)
        {
            int aCounter = 0;
            int bCounter = 0;
            int cCounter = 0;
            int dCounter = 0;
            int eCounter = 0;

            // use foreach because we are not modifying the strings!
            foreach (var s in sAry)
            {
                char first = Char.ToLower(s[0]);
                switch (first)
                {
                    case 'A':
                    case 'a':
                        ++aCounter;
                        break;
                    case 'b':
                        ++bCounter;
                        break;
                    case 'c':
                        ++cCounter;
                        break;
                    case 'd':
                        ++dCounter;
                        break;
                    case 'e':
                        ++eCounter;
                        break;
                }
            }
            Console.WriteLine(" Number of 'A's: {0} \n Number of 'B's: {1} \n Number of 'C's: {2} \n Number of 'D's: {3} \n Number of 'E's: {4} \n ",
                aCounter, bCounter, cCounter, dCounter, eCounter);
        }

        static void sortArray(int[] ary)
        {
            bool madeChanges = true;
            while (madeChanges == true)
            {
                madeChanges = false;
                for (int i = 0; i < ary.Length - 1; ++i)
                {
                    if (ary[i] > ary[i + 1])
                    {
                        int temp = ary[i];
                        ary[i] = i + 1;
                        ary[i + 1] = temp;
                        madeChanges = true;
                    }
                }
            }
        }
    

        static void Main(string[] args)
        {
            /* Arrays and Data Structures
             * 
             * Arrays 
             * Foreach, Switch, and working with collections
             * List
             * LinkedList
             * What is the Difference?
             * 
             * Arrays can only hold a single type and have a fixed length set at contruction. 
             * Arrays can be single or multi dimension. 
             * Arrays can hold any single type, including other arrays! 
             * 
             * Working with collections. 
             * for loop variation foreach
             * switch statement can help with if then, if else 
             * 
             */

            // Ex 1. Calculate ant store the integers 0-99 inclusive and store them in unique varibles. 

            //int[] ary = new int[100];
            //for (int x = 0; x < 100; ++x)
            //{
            //    ary[x] = x;
            //}
            
            // Ex. 2 Create a 2-demensional aray of integers representing a tile set for a scene in a game. Using nexted for loops to examine the default values in the array.

            //int[,] map = new int[20, 30];
            //for (int i = 0; i < map.GetLength(0); ++i)
            //{
            //    for (int j =0; j < map.GetLength(1); ++j)
            //    {
            //        Console.WriteLine("({0}, {1}): {2}", i, j, map[i, j]);
            //    }
            //}
            
            // Ex 3 Populate an array of strings - write a function that checks the first letter of each word and returns the number of works that begin with a, b, c, d and e. 

            //string[] testData = new string[] 
            //{
            //    "apples", "bananas", "aardvark", "Deli", "elephant"
            //};
            //FirstLetters(testData);
            
            // Ex 4 Critial thinking on problem - Write a function that given an array of integer's that arranges the integers in order from smallest to greatest.

            //int[] testInts = new int[] { 5, 4, 3, 2, 1 };

            //sortArray(testInts);

            // Data Structures
            // List and LinkedList
            // Ex 4 - Create a container representing a student's grades and populate it with test data Sort the grades from lowest to highest and return the average.

            //List<float> grades = new List<float>();
            //grades.Add(67f);
            //grades.Add(93f);
            //grades.Add(43f);

            //grades.Sort();
            //Console.WriteLine("Average grade: {0}", grades.Average());

            LinkedList<float> gradesLinked = new LinkedList<float>();
            gradesLinked.AddFirst(67f);
            gradesLinked.AddFirst(93f);
            gradesLinked.AddFirst(43f);

            Console.WriteLine("Average grade: {0}", gradesLinked.Average());
           
        }
    }
}
