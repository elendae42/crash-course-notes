using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Homwork
{
    class Exercise1
    {
        //Ex. 1. Create a struct called Person, with a public string field for name and a public unsigned int field for age. Instance a Queue of Persons and try enqueueing several Persons. Then dequeue      each person and write their name and age to the console.
        public struct Person
        {
            public string userName
            {
                get;
                set;
            }
            public uint userAge
            {
                get;
                set;
            }

            public Person(string name, uint age)
            {
                userName = name;
                userAge = age;
            }


        }
        

    }
}
