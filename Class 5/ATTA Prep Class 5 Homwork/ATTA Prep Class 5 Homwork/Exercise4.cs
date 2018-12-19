using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Homwork
{
    class Exercise4
    {
        //Ex. 4. Write a function that, given a List of strings, sorts the list into alphabetical order and removes any duplicate strings. Use a HashSet to help you with the second task.

        public static void listClean(List<string> list)
        {
            list.Sort();
            HashSet<string> hash = new HashSet<string>(list);
            foreach(string s in hash)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine("");
        }
    }
}
