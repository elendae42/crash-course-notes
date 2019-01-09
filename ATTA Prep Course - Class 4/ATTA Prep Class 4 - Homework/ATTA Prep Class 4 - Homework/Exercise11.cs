using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise11
    {
        // Ex. 11. Write a function that takes two lists of strings as input. The function should read each string in the second list and, if there are any instances of that string in the first list, remove them. Given the following lists as input:
        //List1 contents: {“Alice”, “Bob”, “Alice”, “Carol”, “Daphne”}
        //    List2 contents: {“Alice”, “Daphne”}
        //…the function should modify the first list so that it contains the following:
        //List1 contents: {“Bob”, “Carol”}


        public static List<string> list1 = new List<string>()
        {
            "Alice", "Bob", "Alice", "Carol", "Daphne"
        };
        
        public static List<string> list2 = new List<string>()
        {
            "Alice", "Daphne"
        };

        public static void pruneList(List<string> list1, List<string> list2)
        {
           for (int i = 0; i <= list2.Count -1; ++i)
           {
               for (int j = 0; j <= list1.Count -1; ++j)
               {
                   if(list2[i] == list1[j])
                   {
                       // Console.WriteLine("Match on {0}", list1[j]);  //Print debugging
                       list1.RemoveAt(j);
                       j = 0;
                   }
               }
                
           }
        }
        public static void printList(List<string> list)
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

    }
}
