using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise5
    {
        //    Ex. 5. Write a function that, given a two-dimensional array of integers, returns the sum of every integer in the array.

        public static int rows()
        {
            Console.Write("Please select the number of Rows for you array: ->  \n");
            int rows = Convert.ToInt32(Console.ReadLine());
            return rows;

        }
        public static int columns()
        {
            Console.Write("Please select the number of Columns for you array: ->  \n");
            int columns = Convert.ToInt32(Console.ReadLine());
            return columns;
        }

        public static void testArray(int[,] map)
        {
            for (int i = 0; i < map.GetLength(0); ++i)
            {
                for (int j = 0; j < map.GetLength(1); ++j)
                {
                    map[i, j] = i + j;
                    Console.WriteLine("At ({0}, {1}): the value is {2}", i, j, map[i, j]);
                }
            }
        }
        public static void addArray(int[,] ary)
        {
            int arraySum = 0;
            for (int i = 0; i < ary.GetLength(0); ++i)
            {
                for (int j = 0; j < ary.GetLength(1); ++j)
                {
                    arraySum = arraySum + ary[i, j];
                }
            }
            Console.WriteLine("The total of all values in the array is: {0}", arraySum);

        }
    }
}
