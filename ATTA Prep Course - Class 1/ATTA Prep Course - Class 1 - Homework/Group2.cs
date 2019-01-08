using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Course___Class_1___Homework
{
    class Group2
    {
        // Operators
        // Ex 1.Declare an int named "x" and initialize it with the value "0".
        // Practice changing its value to 5 using the following expressions: (1) x = x + 5; (2)++x;
        // (You'll need to do this a total of 5 times!) (3) x += 5;

        // Commented out code for this exercise:
        //int x = 0;

        //while(x != 5)
        //    x = x + 5;
        //while (x != 5)
        //    ++x;
        //while (x != 5)
        //    x += 5;
        //Console.WriteLine(x);
        static public void PrintResultsEx1()
        {
            Console.WriteLine(
                "This exercise doesn't have an interactive implementation. The code results should look like:\n");
            Console.WriteLine("     int x = 0;");
            Console.WriteLine("     while(x != 5)\n     {\n         x = x + 5;\n     }\n     while(x != 5)\n     {\n         ++x;\n     }\n     while(x != 5)\n     {\n         x += 5;\n     }");
        }

        // Ex 2.Declare an int named "x" and initialize it with the value "3". Using the '*' and '*=' operators, 
        // try to raise x to the powers of 2, 3, and 4.

        // Commented out code for this exercise:
        //int x = 3;
        //x = x * x;
        //x = x * x * x;
        //x = x * x * x * x;
        //x *= x;
        //x *= x *= x;
        //x *= x *= x *= x;
        //Console.WriteLine(x);

        static public void PrintImplementationEx2()
        {
            Console.WriteLine(
                "This exercise doesn't have an interactive implementation. The code results should look like:\n");
            Console.WriteLine("     int x = 3;");
            Console.WriteLine("Raised to the power of 2\n    x = x * x;\n    Console.WriteLine(x)\n");
            Console.WriteLine("Raised to the power of 2\n    x *= x;\n    Console.WriteLine(x)\n");
            Console.WriteLine("Raised to the power of 3\n    x = x * x * x;\n    Console.WriteLine(x)\n");
            Console.WriteLine("Raised to the power of 3\n    x *= x *= x\n    Console.WriteLine(x)\n");
            Console.WriteLine("Raised to the power of 4\n    x = x * x * x * x;\n    Console.WriteLine(x)\n");
            Console.WriteLine("Raised to the power of 4\n    x *= x *= x *= x;\n    Console.WriteLine(x)\n");
        }
        static public void PowersOfTwo()
        {
            int x = 3;
            int power2a = x * x;
            Console.WriteLine("   The outcome of x = x * x: " + power2a);
            x *= x;
            Console.WriteLine("   The outcome of x *= x: " + x);
        }
        static public void PowersOfThree()
        {
            int x = 3;
            int power3a = x * x * x;
            Console.WriteLine("   The outcome of x = x * x * x: " + power3a);
            x *= x *= x;
            Console.WriteLine("   The outcome of x *= x *= x: " + x);
        }
        static public void PowersOfFour()
        {
            int x = 3;
            int power4a = x * x * x * x;
            Console.WriteLine("   The outcome of x = x * x * x * x: " + power4a);
            x *= x *= x *= x;
            Console.WriteLine("   The outcome of x *= x *= x *= x: " + x);
        }
        // Ex 3.Declare a float named "x" and initalize it with the value "6.5f".
        // Declare a float named "y" and initalize it with the value "-6.5f".
        // Declare a bool named "compare." Initialize "compare" as follows: compare = x > 1.5f; 
        // Finally, write "compare" to the console using Console.WriteLine().
        // Predict whether the result will be true or false, then compile and execute your program to check your prediction.

        // Commented out code for this exercise:
        //float x = 6.5f;
        //float y = -6.5f;
        //bool compare01 = x > 1.5f;
        //bool compare02 = y > 1.5f;
        //Console.WriteLine(compare01);
        //Console.WriteLine(compare02);

        //Interactive implemention allows Users to guess true or false 

        static public bool UserGuess(string userChoiceEx3)
        {
            if (userChoiceEx3 == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string UserChoiceEx3()
        {
            userChoiceEx3Menu();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2"))
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
        private static void userChoiceEx3Menu()
        {
            Console.WriteLine(
                " Do you think the outcome of the above comparison will be:\n     (1) True\n     (2) False\n");
            Console.Write("    ->     ");
        }
        public static void CompareUserGuess(bool userGuess, bool compare)
        {
            if (userGuess == compare)
            {
                Console.WriteLine(" You predicted correctly!");
            }
            else
            {
                Console.WriteLine(" Your prediction was incorrect.");
            }
        }
        // Ex 4.Repeat the above exercise with each of the following assignments for "compare." 
        // In each case, predict whether the result will be true or false before execution.
        // If your prediction is incorrect, try to work out why(and be sure to ask for help if you aren't sure!)

        // No new methods created for the interactive implementation of this exercise. It will use the same methods created for Ex 3 to allow the user to predict what the answer will be. 

        // The commented out code belowm will allow you to solve the exercise as described in the problem.
        // compare = x > y;
        // compare = x <= 6.5f;
        // compare = 6.5f == y;
        // compare = x < y || x > y;
        // compare = x > 0f && y > 0f;
        // compare = x * -1f == y;
        // compare = x != y && x < y;

        //float x = 6.5f;
        //float y = -6.5f;

        //bool compare01 = x > y;
        //bool compare02 = x <= 6.5f;
        //bool compare03 = 6.5f == y;
        //bool compare04 = x < y || x > y;
        //bool compare05 = x > 0f && y > 0f;
        //bool compare06 = x * -1f == y;
        //bool compare07 = x != y && x < y;

        //Console.WriteLine(compare01);
        //Console.WriteLine(compare02);
        //Console.WriteLine(compare03);
        //Console.WriteLine(compare04);
        //Console.WriteLine(compare05);
        //Console.WriteLine(compare06);
        //Console.WriteLine(compare07);



    }
}
