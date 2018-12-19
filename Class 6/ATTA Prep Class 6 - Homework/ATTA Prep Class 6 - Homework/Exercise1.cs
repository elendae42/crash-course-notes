using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise1
    {
        // Ex. 1. Write a function that, given a List of integers, removes all copies of the highest and lowest value from the list.Challenge: Try to do this without using the List.Min() or List.Max() methods!'

        private static int itemsDesired;
        public static int ItemsDesired
        {
            get
            {
                return itemsDesired;
            }
            set
            {
                if(value < 3)
                {
                    itemsDesired = 3;
                }
                else
                {
                    itemsDesired = value;
                }
            }
        }
        public static List<int> createList()
        {
            var intList = new List<int>();
            Console.Write("Please the number of items you would like to add to your list (must be greater than 3): ->   ");
            ItemsDesired = int.Parse(Console.ReadLine());
            for (int i = 0; i < itemsDesired; ++i)
            {
                Console.Write("Please select an integer to add to the list: ->   ");
                int x = int.Parse(Console.ReadLine());
                intList.Add(x);
            }
            return intList;
        }
        public static void pruneList1(List<int> list)
        {
            int iHigh = list.Max();
            int iLow = list.Min();
            while(list.Contains(iHigh))
            {
                list.Remove(iHigh);
            }
            while(list.Contains(iLow))
            {
                list.Remove(iLow);
            }
        }
        public static void pruneList2(List<int> list)
        {
            int iHigh = list[0];
            int iLow = list[0]; 
            for(int i = 0; i < list.Count; ++i)
            {
                if(iHigh < list[i])
                {
                    iHigh = list[i];
                }
                if(iLow > list[i])
                {
                    iLow = list[i];
                }
            }
            while (list.Contains(iHigh))
            {
                list.Remove(iHigh);
            }
            while (list.Contains(iLow))
            {
                list.Remove(iLow);
            }
        }
        public static void printList(List<int> list)
        {
            foreach(int i in list)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}
