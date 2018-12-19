using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise1
    {
        // Ex 1. Declare an array of 50 integers.Assign each item in the array to consecutive multiples of 5, starting with 5: ary[0] = 5, ary[1] = 10, ary[2] = 15, etc.

        static public int[] multiples5 = new int[50];
        static public int chooseNumber()
        {
            Console.Write("Please select a number you would like to see 50 consecutive multiples of: ->  ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            return userChoice;
        }
        static public void homeworkEx1(int num)
        {
            for (int i = 0; i < multiples5.Length; ++i)
            {
                int x = i + 1;
                //Console.WriteLine(x);  // This is print Debugging
                multiples5[i] = x * num;
                //Console.WriteLine("{0}", multiples5[i]);  // This is print Debugging

            }
        }
        static public void printEx1()
        {
            foreach (int num in multiples5)
            {
                Console.WriteLine("{0}", num);
            }
        }

    }
}
