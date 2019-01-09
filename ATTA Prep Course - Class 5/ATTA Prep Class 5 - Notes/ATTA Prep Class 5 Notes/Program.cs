using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Notes
{
    class Program
    {
        // Agenda:
        // Queue and Stacks
        // Recursion
        // HashSet and Hash functions
        // Dictionary
        // Structs
        // Big O notation

        
        // Queues:
        // Queue is a data structure that is good to use when the order of items being added or removed is important to keep track of.
        // Queues are FIFO structure: First in, First out. (Like a line or grab a number system)
        // We us the Enqueue() method to add an item to a item to the Queue and Dequeue() method to remove en item. 

        // EX 1. create a class that represeents a call center, it has a queue and assigns call based on how long the caller has been in queue. 

        class Caller
        {
            // This is how we normally do thing
            //private string name;
            //public string Name
            //{
            //    get
            //    {
            //        return name;
            //    }
            //    set
            //    {
            //        name = value;
            //    }
            //}

            // Here is another way if you are are just doing read/write access.
            public string Name
            {
                get;
                set;
            }
            public string Issue
            {
                get;
                set;
            }

            //Constructor
            public Caller()
            {
                Name = "Unknown - Please enter the customers name.";
                Name = Console.ReadLine();
                Issue = "Unknown - Please note your customers issues.";
                Issue = Console.ReadLine();
            }
            public Caller(string name, string issue)
            {
                Name = name;
                Issue = issue;
            }
        }

        class CallCenter
        {
            private Queue<Caller> callers;

            // Constructor
            public CallCenter()
            {
                callers = new Queue<Caller>();
            }

            // Dealing with callers
            public void AddCaller(string name, string issue)
            {
                callers.Enqueue(new Caller(name, issue));
            }

            public Caller GetCaller()
            {
                if (callers.Any())
                {
                    return callers.Dequeue();
                }
                return null;
                
            }
       
        }

        // Reference type vs Value type
        // When a copy of a value type is made you get a actual copy of data in the memory.
        // When you make a copy of reference you are making a copy of the pointer, not the actual data. 
        // Most things are references (ie - class, objects - this is how we can change an object within a method.)
        // Shallow Copy = Reference
        // Deep Copy = Data




        // Stacks:
        // A stack is a data structure that is good to use when the order in which items are added in important to keep track of.
        // Stacks are LIFO structures: Last In, First Out.
        // We use the Push() method to add an item to a stack, and Pop() method to remove items. 

        // EX 2. Write a function that, given a string, using a Stack<char> to print the reversal of the string to the console. 

        static void ReverseString(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());

            }
            Console.WriteLine();

        }

        // The Call Stack:
        // Modern programming languages usually organize blocks of code into functions that can be called when needed during the execution of a program.
        // For a program to compute correctly, it has to keep track of what functions have been called and in what order to make sure it doesnt' lose track of where it is.

        // EX 3 - Write a recursive fuction that calculates the summation of an integer. us the debugger to observe how the call stack keeps track of each successive function call. 

        static int Summation(int n)
        {
            if (n == 0) return 0;
            return n + Summation(n - 1);
        }

        // HashSets:
        // HashSet is a highly specialized container that can be used to quickly store and find collections of unique items. 
        // Since HashSet is a set, there can be no duplicate items. For example if you try to add 5 to a HashSet<int> that already contains 5 a duplicate item will not be created.
        // Hash Set allow fast random access to elements by using a hashing function to generate indices from data.
        // Elements in a HashSet can't be called by the index like you can in a list ex. "hs[4]" will not work.

        // EX 4 - Declare an array of integers and initialize it witha  group of values with repeats - Convert to Hashset and print it.

        // Dictionary:
        // Dictionary is an associative container; this means that it contains a series of keys /value pairs that relate to another.
        // all keys must be the same time and all values must be the same type but the key and the value do not need to be the same type.
        // Example = EmployeeID(int) : EmployeeName(string)

        // EX 5 Define a struct call Student that contains Public fields  and Dictionary of students.
        // Note: Structs are Value types - Classes are Reference Types = Structs can be copied.

        //struct Student
        //{
        //    public string name;
        //    public int grade;
        //    public float GPA;

        //    public Student(string _name, int _grade, float _GPA)
        //    {
        //        name = _name;
        //        grade = _grade;
        //        GPA = _GPA;

        //    }
        //}

        static void Main(string[] args)
        {
            //       EX. 1 Calls
            //CallCenter cc = new CallCenter();

            //cc.AddCaller("Chi", "Toy went under the couch, please get it!");
            //cc.AddCaller("Luna", "REALLY!? This can't be right, she is a complete airhead.");
            //cc.AddCaller("Artemis", "I need ear scratches!");

            //var caller = cc.GetCaller();
            //if (caller != null)
            //{
            //    Console.WriteLine("{0}  -  {1}", caller.Name, caller.Issue);
            //}
            //caller = cc.GetCaller();
            //if (caller != null)
            //{
            //    Console.WriteLine("{0}  -  {1}", caller.Name, caller.Issue);
            //}
            
            //caller = cc.GetCaller();
            //if (caller != null)
            //{
            //    Console.WriteLine("{0}  -  {1}", caller.Name, caller.Issue);
            //}
            //caller = cc.GetCaller();
            //if (caller != null)
            //{
            //    Console.WriteLine("{0}  -  {1}", caller.Name, caller.Issue);
            //}

            //         EX 2. Reverse String with Stack
            //ReverseString("This is a magnificent sentence!");

            //         EX 3. Call stack and recursive functions
            //Console.WriteLine(Summation(5));

            //         EX 4. HashSet from Array
            //int[] ary = new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 7, 8, 9, 10 };
            //HashSet<int> hs = new HashSet<int>(ary);
            //foreach(int x in hs)
            //{ 
            //    Console.WriteLine(x); 
            //}

            //        Ex 5 Dictionary/Struct
            //var roster = new Dictionary<string, Student>();
            //roster["Alice"] = new Student("Alice", 8, 3.7f);
            //roster["Bob"] = new Student("Bob", 12, 2.3f);

            //Student foundStudent = roster["Bob"];
            //Console.WriteLine(foundStudent.GPA);
            
        }
    }
}
