using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Course___Class_1___Homework
{
    class Program
    // Homework exercises program has a standard menu with switch cases that allows the user to select which program exercise they would like to execute. Each exercise is housed in its own Class file under the exercise number. If you wish to view the code for a given exercise please look at the appropriate class file. 

    // To run a specific project in debug mode ensure the correct project is selected from the dropdown next to the 'Start' button in VS.
    {
        private static void ExerciseGroup()
        {
            Console.WriteLine("Please select which type of exercise you would like to see:\n");
            Console.WriteLine(
                " 1. Basics, Types and Variables");
            Console.WriteLine(
                " 2. Operators");
            Console.WriteLine(
                " 3. Functions");
            Console.Write("  ->   ");
        }
        static string SelectGroup()
        {
            ExerciseGroup();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3"))
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
        static void GetExerciseGroup(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    string exChoice1 = SelectExerciseBasic();
                    GetExerciseBasic(exChoice1);
                    break;
                case "2":
                    string exChoice2 = SelectExerciseOperators();
                    GetExerciseOperators(exChoice2);
                    break;
                case "3":
                    string exChoice3 = SelectExerciseFunctions();
                    GetExerciseFunctions(exChoice3);
                    break;
            }
        }
        private static void ExerciseListBasic()
        {
            Console.WriteLine("Please select which exercise you would like to see:\n");
            Console.WriteLine(
                " 1. Create a new Visual C# Console application and name it whatever you wish. Within the Main() function,\n    write a message to the console by calling the Console.WriteLine() function.\n");
            Console.WriteLine(
                " 2. Declare a string variable and initialize it with the text, 'This is one half'. Declare a second string and\n    initialize it with the text 'of a sentence'. Use the Console.Write() function and your two\n    string variables to write -This is one half of a sentence.- to the console.\n");
            Console.WriteLine(
                " 3. Declare an int variable named 'myInt' and try to initialize it with the following values: 10, 100, 1000,\n     10000, etc., adding a zero each time. When you eventually reach a value that is\n     invalid, read the resulting error message. Determine what different type you can declare that will allow you\n     to store larger integers.\n");
            Console.WriteLine(
                " 4. Declare a float variable named 'myFloat' and assign it the value '1.123456789f'. Declare a double and assign it\n     the value '1.123456789' (Note that the only difference between these values is\n     the 'f' at the end of the float value.) Use Console.Writeline() to write each variable to the console.\n      Compile and execute the program and think about the results; how is a float different from a double?\n     Keep experimenting with different values to get a feel for how these two types behave.\n");
            Console.Write("  ->   ");
        }
        private static void ExerciseListOperators()
        {
            Console.WriteLine("Please select which exercise you would like to see:\n");
            Console.WriteLine(
                " 1. Declare an int named 'x' and initialize it with the value '0'.\n      Practice changing its value to 5 using the following expressions: (1) x = x + 5; (2)++x\n");
            Console.WriteLine(
                " 2. Declare an int named 'x' and initialize it with the value '3'. Using the '*' and '*=' operators, try to raise x to the powers of 2, 3, and 4.\n");
            Console.WriteLine(
                " 3. Declare a float named 'x' and initialize it with the value '6.5f'.\n      Declare a float named 'y' and initialize it with the value '-6.5f.\n      Declare a bool named 'compare'. Initialize 'compare' as follows: compare = x > 1.5f; \n      Finally, write 'compare' to the console using Console.WriteLine().\n      Predict whether the result will be true or false, then compile and execute your program to check your prediction.\n");
            Console.WriteLine(
                " 4. Repeat the above exercise with each of the following assignments for 'compare.'\n       In each case, predict whether the result will be true or false before execution.\n      compare = x > y;\n      compare = x <= 6.5f;\n      compare = 6.5f == y;\n      compare = x < y || x > y;\n      compare = x > 0f && y > 0f;\n      compare = x * -1f == y;\n      compare = x != y && x < y;\n      ");
            Console.Write("  ->   ");
        }
        private static void ExerciseListFunctions()
        {
            Console.WriteLine(
                " 1. Write a function called PrintString that takes a string as input and has no output(use the keyword 'void'\n      to indicate that there is no output.) Your function should write the provided\n      string to the console.\n");
            Console.WriteLine(
                " 2. Write a function that, when given an integer value n, returns the summation of 1 through n.\n");
            Console.WriteLine(
                " 3. Write a function called 'TakeDamage' that simulates a character in a game taking hitpoint damage. The\n       function should take two integers as input: One to represent the current HP\n       of the target, and one to represent damage taken. Return the number of HP remaining.\n");
            Console.WriteLine(
                " 4. Ex. 8 Write a function that takes an integer as input and returns true if the integer is positive and false if it is 0 or negative.\n      Write a second function that takes an integer as input and returns true if the integer is even and false if it is odd.\n      Write a third function that takes an integer as input and returns true if it is a positive and even integer and false if not. \n      Have your third function make use of your first two functions in order to return the correct answer.\n");
            Console.WriteLine(
                " 5. Continue to practice writing functions by imagining different simple tasks that they can perform.\n    Here are some ideas:\n\n    -Given three floating point numbers, return the average of all three.\n    -Given two integer values, return true if they are equal and false if not.\n    -Given an integer value, return the square of that integer.\n    -Given two strings, combine both strings into a single string and write the new string to the console.\n    -Given the lengths of two sides of a right triangle, return the length of the hypotenuse\n");
            Console.Write("  ->   ");
        }
        static string SelectExerciseBasic()
        {
            ExerciseListBasic();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3") || (userChoice == "4"))
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
        static string SelectExerciseOperators()
        {
            ExerciseListOperators();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3") || (userChoice == "4"))
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
        static string SelectExerciseFunctions()
        {
            ExerciseListFunctions();
            string userChoice = "null";
            while (userChoice == "null")
            {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3") || (userChoice == "4") || (userChoice == "5"))
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
        static void GetExerciseBasic(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    string userMessage = Group1.UserMessageEx1();
                    Group1.WriteMessageEx1(userMessage);
                    break;
                case "2":
                    string firstPart = Group1.FirstHalfEx2();
                    string secondPart = Group1.SecondHalfEx2();
                    Group1.CombineMessagesEx2(firstPart, secondPart);
                    break;
                case "3":
                    Group1.PrintResultsEx3();
                    break;
                case "4":
                    Group1.PrintResultsEx4();
                    break;
            }
        }

        static void GetExerciseOperators(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    Group2.PrintResultsEx1();
                    break;
                case "2":
                    Group2.PrintImplementationEx2();
                    Group2.PowersOfTwo();
                    Group2.PowersOfThree();
                    Group2.PowersOfFour();
                    break;
                case "3":
                    Console.WriteLine("The variables for the comparisons are\n    x = 6.5f\n    y = -6.5f");
                    float x = 6.5f;
                    float y = -6.5f;
                    Console.WriteLine("The first comparison: x > 1.5f");
                    bool compare01 = x > 1.5f;
                    string userChoiceEx301 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect01 = Group2.UserGuess(userChoiceEx301);
                    Group2.CompareUserGuess(IsUserChoiceCorrect01, compare01);
                    Console.WriteLine("The second comparison: y > 1.5f");
                    bool compare02 = y > 1.5f;
                    string userChoiceEx302 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect02 = Group2.UserGuess(userChoiceEx302);
                    Group2.CompareUserGuess(IsUserChoiceCorrect02, compare02);
                    break;
                case "4":
                    float x4 = 6.5f;
                    float y4 = -6.5f;
                    bool ex4Compare01 = x4 > y4;
                    bool ex4Compare02 = x4 <= 6.5f;
                    bool ex4Compare03 = 6.5f == y4;
                    bool ex4Compare04 = x4 < y4 || x4 > y4;
                    bool ex4Compare05 = x4 > 0f && y4 > 0f;
                    bool ex4Compare06 = x4 * -1f == y4;
                    bool ex4Compare07 = x4 != y4 && x4 < y4;
                    Console.WriteLine("The variables for the comparisons are\n    x = 6.5f\n    y = -6.5f");
                    // Comparison 1
                    Console.WriteLine("The first comparison: x > y");
                    string userChoiceEx401 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect401 = Group2.UserGuess(userChoiceEx401);
                    Group2.CompareUserGuess(IsUserChoiceCorrect401, ex4Compare01);
                    // Comparison 2
                    Console.WriteLine("The second comparison: x <= 6.5f");
                    string userChoiceEx402 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect402 = Group2.UserGuess(userChoiceEx402);
                    Group2.CompareUserGuess(IsUserChoiceCorrect402, ex4Compare02);
                    // Comparison 3
                    Console.WriteLine("The first comparison: 6.5f == y");
                    string userChoiceEx403 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect403 = Group2.UserGuess(userChoiceEx403);
                    Group2.CompareUserGuess(IsUserChoiceCorrect403, ex4Compare03);
                    // Comparison 4
                    Console.WriteLine("The first comparison: x > y");
                    string userChoiceEx404 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect404 = Group2.UserGuess(userChoiceEx404);
                    Group2.CompareUserGuess(IsUserChoiceCorrect404, ex4Compare04);
                    // Comparison 5
                    Console.WriteLine("The first comparison: x > 0 && y > 0");
                    string userChoiceEx405 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect405 = Group2.UserGuess(userChoiceEx405);
                    Group2.CompareUserGuess(IsUserChoiceCorrect405, ex4Compare05);
                    // Comparison 6
                    Console.WriteLine("The first comparison: x * -1f == y");
                    string userChoiceEx406 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect406 = Group2.UserGuess(userChoiceEx406);
                    Group2.CompareUserGuess(IsUserChoiceCorrect406, ex4Compare06);
                    // Comparison 7
                    Console.WriteLine("The first comparison: x != y && x < y");
                    string userChoiceEx407 = Group2.UserChoiceEx3();
                    bool IsUserChoiceCorrect407 = Group2.UserGuess(userChoiceEx407);
                    Group2.CompareUserGuess(IsUserChoiceCorrect407, ex4Compare07);
                    break;
            }
        }
        static void GetExerciseFunctions(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "2":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "3":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "4":
                    Console.WriteLine("Not yet implemented");
                    break;
                case "5":
                    Console.WriteLine("Not yet implemented");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(160, 40);
            string groupChoice = SelectGroup();
            GetExerciseGroup(groupChoice);
            Console.ReadKey();
        }
    }
}
