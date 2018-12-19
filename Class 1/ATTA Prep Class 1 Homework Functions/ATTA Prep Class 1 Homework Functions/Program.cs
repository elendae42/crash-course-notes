using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_1_Homework_Functions
{
    class Program
    { 
        static void PrintString(string s)
        {
            Console.WriteLine(s);
        }

        static int Summation(int n)
        {
            int val = 0;
            val = n * (n + 1) / 2;
            return val;
        }

        static int TakeDamage(int c, int d)
        {
            int newHP = 0;
            newHP = c - d;
            return newHP;
            //return c - d;
        }

        static bool IsPositive(int x)
        {
            bool compare = x >= 1;
            return compare;
            //return x >= 1;
        }

        static bool IsEven(int x)
        {
            int mod = x % 2;
            bool final = mod == 0;
            return final;
            //return (x % 2) == 0;
        }

        static bool IsBoth(int x)
        {
            bool both = IsPositive(x) && IsEven(x);
            return both;
            //return IsPositive(x) && IsEven(x);
        }

        static float Average(float x, float y, float z)
        {
            return (x + y + z) / 3;
        }

        static bool IsEqual(int x, int y)
        {
            return x == y;
        }

        static double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        static void NewString(string x, string y)
        {
            Console.WriteLine(x + y);
        }

        static double Hypotenuse(int a, int b)
        {
            double c = ((a * a) + (b * b));
            return Math.Sqrt(c);
        }

        static void Main(string[] args)
        {

            // Functions
            // Ex 1.Write a function called PrintString that takes a string as input and has no output(use the keyword 'void'
            // to indicate that there is no output.) Your function should write the provided string to the console. 
            // Here is what it will probably look like:

            // static void PrintString(string s)
            // {
            //     Console.WriteLine(s);
            // }

            // Now declare a string called "message" and initialize it with the text, "Test string!"
            // Call your PrintString function with "message" as its input.
            // Compile and and run your program to ensure that the function is working properly.

            // As a follow - up, try calling your function with a string literal instead, 
            // e.g., PrintString("Stay awhile and listen!");
            // What is the result ? Try to figure out why you got the result that you did.

            string message = "This is a test! I'm stored as a variable.";
            PrintString(message);

            PrintString("Stay awhile and listen. I'm an argument of the function");


            // Ex 2.Write a function that, when given an integer value n, returns the summation of 1 through n. 
            // If you're not familiar with it, here's a mathematical formula your function can use to get the correct result:

            // summation = n * (n + 1) / 2

            // Test your function by calling it with the value '5' and using the console to confirm that the return value is 15.

            Console.WriteLine(Summation(5));
            Console.WriteLine(Summation(10));
            Console.WriteLine(Summation(15));


            // Ex 3.Write a function called "TakeDamage" that simulates a character in a game taking hitpoint damage.
            // The function should take two integers as input: One to represent the current HP of the target,
            // and one to represent damage taken. Return the number of HP remaining.

            Console.WriteLine(TakeDamage(10, 3));
            Console.WriteLine(TakeDamage(90, 100));
            Console.WriteLine(TakeDamage(150, 3));

            // Ex. 4 Write a function that takes an integer as input and returns 
            // true if the integer is positive and false if it is 0 or negative. 
            // Write a second function that takes an integer as input and returns 
            // true if the integer is even and false if it is odd 
            // (to work this out you’ll probably need to use the ‘remainder’ operator. see the link below for help!)

            // Test both of your functions to see if they seem to be working properly. 
            // If so, write a third function that takes an integer as input and returns 
            // true if it is a positive integer and false if not. 
            // Have your third function make use of your first two functions in order to return the correct answer.

            // Link to help on the remainder operator:
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/remainder-operator

            Console.WriteLine(IsPositive(5));
            Console.WriteLine(IsPositive(10));
            Console.WriteLine(IsPositive(0));
            Console.WriteLine(IsPositive(-4));

            Console.WriteLine(IsEven(3));
            Console.WriteLine(IsEven(4));
            Console.WriteLine(IsEven(0));
            Console.WriteLine(IsEven(-5));

            Console.WriteLine(IsBoth(-5));
            Console.WriteLine(IsBoth(4));
            Console.WriteLine(IsBoth(0));
            Console.WriteLine(IsBoth(5));


            // Ex 5.Continue to practice writing functions by imagining different simple tasks that they can perform.
            // Here are some ideas:

            // -Given three floating point numbers, return the average of all three.
            // -Given two integer values, return true if they are equal and false if not.
            // -Given an integer value, return the square of that integer.
            // -Given two strings, combine both strings into a single string and write the new string to the console.
            // -Given the lengths of two sides of a right triangle, return the length of the hypotenuse
            // (Take a look at the Math class linked below to find a function you can use to calculate square roots, 
            // as well as many other common mathematical operations.)
            // https://msdn.microsoft.com/en-us/library/system.math(v=vs.110).aspx

            Console.WriteLine(Average(1.2f, 2.5f, 3.7f));
            Console.WriteLine(Average(1f, 2f, 3f));
            Console.WriteLine(IsEqual(1, 4));
            Console.WriteLine(IsEqual(2, 2));
            Console.WriteLine(SquareRoot(9));
            Console.WriteLine(SquareRoot(97));
            NewString("This is part 1", " and this is part 2.");
            Console.WriteLine(Hypotenuse(4, 4));

        }
    }
}
