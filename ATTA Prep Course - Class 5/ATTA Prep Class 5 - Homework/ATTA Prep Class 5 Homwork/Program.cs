using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Homwork
{
    class Program
    {

        private static void exerciseList()
        {
            Console.WriteLine("Please select which exercise you would like to see:\n");
            Console.WriteLine(
                " 1. Create a struct called Person, with a public string field for name and a public unsigned int field for age. Instance a Queue of Persons\n    and try enqueueing several Persons. Then dequeue each person and write their name and age to the console.\n");
            Console.WriteLine(
                " 2. Create a function that accepts a string as input and outputs an encrypted version of the string.\n");
            Console.WriteLine(
                " 3. Follow-up: Write a decryption function that, given a string encrypted using the function in Ex. 2, will return a decrypted string.\n");
            Console.WriteLine(
                " 4. Write a function that, given a List of strings, sorts the list into alphabetical order and removes any duplicate strings.\n");
            Console.WriteLine(
                " 5. Write your own hashing function!\n");
            Console.WriteLine(
                " 6. Declare and initialize a new Dictionary<string, int>. Now have your program enter a loop and, each cycle, do the following: Ask the user\n    to enter a person’s first name and store the name in a string(hint: Look up “Console.ReadLine()” to learn how to get user input\n    and assign it to a variable). Check to see if the name exists as a key in the Dictionary. If not, add the name to the Dictionary\n    and map it to an integer value that increases with each name added, starting with 0.\n");
            Console.WriteLine(
                " 7. BlizzCon is almost upon us, and your task is to create a class called TicketVendor that ensures that early buyers get BlizzCon tickets.\n    Modify the Person struct in Ex. 1. and provide it with a public bool field called “hasTicket”. Provide your TicketVendor\n    class with a private Queue<Person> called “ticketQueue” and a private List<Person> called “completedList.”\n");
            Console.Write("  ->   ");
        }

        static string selectExercise()
        {
            exerciseList();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3") || (userChoice == "4") || (userChoice == "5") || (userChoice == "6") || (userChoice == "7"))
                {
                    return userChoice;
                }
                else
                {
                    Console.WriteLine("Invalid options - please select from the list above.");
                    userChoice = "null";
                }
            }
            return userChoice;
        }

        static void getExercise(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    Queue <Exercise1.Person> persons = new Queue<Exercise1.Person>();
                    persons.Enqueue(new Exercise1.Person("Chi", 2));
                    persons.Enqueue(new Exercise1.Person("Luna", 18));
                    persons.Enqueue(new Exercise1.Person("Artimas", 20));
                    persons.Enqueue(new Exercise1.Person("Diana", 4));
                    var user = persons.Dequeue();
                    Console.WriteLine("User Name: {0}  -  age: {1}", user.userName, user.userAge);
                    var user1 = persons.Dequeue();
                    Console.WriteLine("User Name: {0}  -  age: {1}", user1.userName, user1.userAge);
                    var user2 = persons.Dequeue();
                    Console.WriteLine("User Name: {0}  -  age: {1}", user2.userName, user2.userAge);
                    var user3 = persons.Dequeue();
                    Console.WriteLine("User Name: {0}  -  age: {1}", user3.userName, user3.userAge);
                    break;
                case "2":
                case "3":
                    string option = Exercise2.operationChoice();
                    string uWord = Exercise2.userWord();
                    if (option == "encode")
                    {
                        Console.Write("Your encrypted word is:  ");
                        Exercise2.encrypt(uWord);
                    }
                    if (option == "decode")
                    {
                        Console.Write("Your decrypted word is:  ");
                        Exercise2.decrypt(uWord);
                    }
                    break;
                case "4":
                    List<string> newList = new List<string>()
                    {
                        "One", "Two","Three","Three","Four"
                    };
                    Exercise4.listClean(newList);
                    break;
                case "5":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "6":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "7":
                    Console.WriteLine("Not yet implemented");
                    
                    break;

            }
        }

        static void Main(string[] args)
        {

            // Session 5 - Data Structures Part 1.
            // Structures to review:
            // - Queue      :   https://msdn.microsoft.com/en-us/library/7977ey2c(v=vs.110).aspx
            // - Stack      :   https://msdn.microsoft.com/en-us/library/3278tedw(v=vs.110).aspx
            // - HashSet    :   https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx
            // - Dictionary :   https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx

            // **** Additional Reading ****
            // Value and Reference types  :  http://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type
            // Hashing                    :  https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/tutorial/
            // Big O Notation             :   https://rob-bell.net/2009/06/a-beginners-guide-to-big-o-notation/

            // **** Glossary ****
            // Queue – A data structure that employs FIFO (first in, first out) data access: if we place items A, B, and C into the Queue in that order, then we begin to request items, A, B, and C will be removed from the Queue and returned to us in that order.
            // Stack – A data structure that employs LIFO(last in, first out) data access: if we place items A, B, and C into the Stack in that order, then we begin to request items, C, B, and A will be removed from the Stack and returned to us in that order.
            // Hashing function – A function that takes some form of input and, through various mathematical processes, returns a new value derived from the input. Hashing functions are used in numerous programming applications including data structure indexing, file integrity checking(see, e.g., MD5), and sophisticated cryptography.
            // Hash Set – A data structure that stores a collection of unique items by employing a hash function to produce indices at which to place them.Because this type of hash function is usually fairly simple, a Hash Set can find stored items very quickly no matter how large the set becomes.
            // Dictionary – A data structure that stores key / value pairs and maps a value onto a key. For example, a Dictionary<string, int> might be used to associate a person’s name with her age.There are many data structures that employ similar behavior, including maps, associative arrays, and symbol tables.
            // Value type – In C#, a value type is any type that holds its own data in memory. If we instance a value type object and then instance a second object and set it equal to the first, the second object will make a copy of the first object’s data and store it in memory. If you modify the first object, the second object will not be affected because they are distinct copies. A copy of this kind is called a deep copy, since an actual copy of the data is made.
            // Reference type – In C#, a reference type is any type that stores a pointer to specific data object in memory. If you instance a reference type, initialize it with a new object, and then declare a second reference type and set it equal to the first, both references will refer to the same, single object. If you modify the first reference, the changes will apply to the second reference as well. A copy of this kind is called a shallow copy, since we haven’t actually copied the data being referenced, only the reference itself.
            // Struct – In C#, a struct is similar to a class. There are a couple of differences, but probably the most important one is that a struct is a value type, whereas a class is a reference type. We generally prefer to use structs when we need an object to hold a small number of simple public fields.
            // Call stack – Programming languages use call stacks to keep track of where they are in execution.Each time a function calls another function, the new function is pushed onto the stack; when the program exits a function, that function is popped off of the stack and execution returns to the point in the next function down at which the exiting function was called.
            // Recursive function – A recursive function is a function that calls itself as part of its execution.Recursion can be tricky to reason about and takes some study and practice to master, but it’s a fundamental technique that we can use in all kinds of applications. For example, compilers like Visual Studio invariably use recursive algorithms to parse the code we write and transform it into whatever new form it needs to take.
            // Big O Notation – This is a shorthand that we use to describe the general complexity of an algorithm, usually relative to some variable value. For example, if an algorithm has O(1) complexity, this means that it runs at constant time and can be relied upon to stay at about the same level of complexity regardless of other factors.But if an algorithm has O(n) complexity, it runs at linear time; it becomes more complex as ‘n’ becomes larger.

            Console.SetWindowSize(160, 40);
            string userChoice = selectExercise();
            getExercise(userChoice);
            Console.ReadKey();


        }
    }
}
