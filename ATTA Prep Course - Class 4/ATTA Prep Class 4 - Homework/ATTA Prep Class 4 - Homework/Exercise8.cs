using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise8
    {

        //  Ex. 8. Write a function that, given a list of integers, returns a new list that contains all of the even integers in the input list.

        //  Ex. 9. Write a variation of the function described in Ex. 8. Instead of returning a new list, have your function modify the input list by removing all odd integers.

        public static List<int> numbers = new List<int>();
       

        public static void addNumbers(int a, int b)
        {
            if (a < b)
            {
                for (int i = a; i <= b; ++i)
                {
                    numbers.Add(i);
                    // Console.WriteLine("{0}", i);   // Print Debug
                }
            }
            else
            {
                for (int i = b; i <= a; ++i)
                {
                    numbers.Add(i);
                    // Console.WriteLine("{0}", i);   // Print Debug
                }
            }
        }

        public static int firstNumber()
        {
            {
                Console.Write("Please select the first number in your range ->  ");
                int first = int.Parse(Console.ReadLine());
                return first;
            }
        }
        public static int secondNumber()
        {
            {
                Console.Write("Please select the second number in your range ->  ");
                int second = int.Parse(Console.ReadLine());
                return second;
            }
        }
        public static List<int> evensOnly(List<int> list)
        {
            List<int> evensOnly = new List<int>();
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i] % 2 == 0)
                {
                    evensOnly.Add(list[i]);
                }
                //else
                //{
                //    continue;
                //}
            }
            return evensOnly;
        }
        public static List<int> oddsOnly(List<int> list)
        {
            List<int> oddsOnly = new List<int>();
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i] % 2 == 1)
                {
                    oddsOnly.Add(list[i]);
                }
                //else
                //{
                //    continue;
                //}
            }
            return oddsOnly;
        }
        public static void printList(List<int> list)
        {
            foreach (int i in list)
                Console.WriteLine("Is even: {0}", i);
        }
    }
}
