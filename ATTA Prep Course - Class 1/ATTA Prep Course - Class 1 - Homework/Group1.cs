using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Course___Class_1___Homework
{
    class Group1
    {
        // Basics, Types and Variables
        // Ex 1. Create a new Visual C# Console application and name it whatever you wish. Within the Main() function, 
        // write a message to the console by calling the Console.WriteLine() function.

        // This implementation of the assignment allows the user to imput any string they would like to print to the console. 
        // The only needed bit of the code to complete the above assignment is:
        //Console.WriteLine("Hello World!");
        static public string UserMessageEx1()
        {
            Console.WriteLine("Please imput the string you would like to print to console.");
            string message = Console.ReadLine();
            return message;
        }
        static public void WriteMessageEx1(string userMessage)
        {
            Console.WriteLine(userMessage);
        }
        // Ex 2. Declare a string variable and initialize it with the text, "This is one half". 
        // Declare a second string and initialize it with the text "of a sentence." Use the Console.Write()
        // function and your two string variables to write "This is one half of a sentence." to the console.

        // This implementation allow the user to set both the first and second strings.
        // The only bit of code needed to complete the assignment as described above is:
        //string firstPart = "This is the first part of the sentence ";
        //string secondPart = "and this is the second part.";
        //Console.Write(firstPart + secondPart);
        static public string FirstHalfEx2()
        {
            Console.WriteLine("Please imput the first half of the message to print to console.");
            string message = Console.ReadLine();
            return message;
        }
        static public string SecondHalfEx2()
        {
            Console.WriteLine("Please imput the second half of the message to print to console.");
            string message = Console.ReadLine();
            return message;
        }
        static public void CombineMessagesEx2(string firstHalf, string secondHalf)
        {
            Console.Write(firstHalf + secondHalf);
        }
        //Ex 3. Declare an int variable named "myInt" and try to initalize it with the following values: 
        // 10, 100, 1000, 10000, etc., adding a zero each time. When you eventually reach a value that is invalid, 
        //read the resulting error message. Determine what different type you can declare that will allow you to store larger integers.

        // Implementation on this exercise prints out the final results. The code needed to test this is commented out below.
        //int myInt01 = 10;
        //int myInt02 = 100;
        //int myInt03 = 1000;
        //int myInt04 = 10000;
        //int myInt05 = 100000;
        //int myInt06 = 1000000;
        //int myInt07 = 10000000;
        //int myInt08 = 100000000;
        //int myInt09 = 1000000000;
        //long myLong = 10000000000;

        static public void PrintResultsEx3()
        {
            Console.WriteLine(
                "This exercise can't be configured to take user imput however the resulting code block looks similar to this:\n");
            Console.WriteLine(
                "     int myInt01 = 10;\n     int myInt02 = 100;\n     int myInt03 = 1000;\n     int myInt04 = 10000;\n     int myInt05 = 100000;\n     int myInt06 = 1000000;\n     int myInt07 = 10000000;\n     int myInt08 = 100000000;\n     int myInt00 = 1000000000;\n     long myLong = 10000000000;\n     ");              
        }
        // Ex 4. Declare a float variable named "myFloat" and assign it the value "1.123456789f".
        // Declare a double and assign it the value "1.123456789" (Note that the only difference between these 
        // values is the 'f' at the end of the float value.) Use Console.Writeline() to write each variable to the console. 
        // Compile and execute the program and think about the results; how is a float different from a double? 
        // Keep experimenting with different values to get a feel for how these two types behave.

        // Implementation on this exercise prints out the final results. The code needed to test this is commented out below.
        //float myFloat = 1.123456789f;
        //double mydouble = 1.123456789;
        //Console.WriteLine(myFloat);
        //Console.WriteLine(mydouble);
        static public void PrintResultsEx4()
        {
            Console.WriteLine(
                "This exercise can't be configured to take user imput however the resulting code block looks similar to this:\n");
            Console.WriteLine(
                "     float myFloat = 1.123456789f;\n     double mydouble = 1.123456789;\n     Console.WriteLine(myFloat);\n     Console.WriteLine(mydouble);\n");
        }
    }
}
