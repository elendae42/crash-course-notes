using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_2___Notes
{
    class Program
    {
        static double Hypotenuse(double a, double b)
        {
            // Some inputs are invalid
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Error - Invalid input");
                return -1;
            }
            else
            {
                double c = (a * a) + (b * b);
                return Math.Sqrt(c);
            }

        }
        // Print all even number up to but not including 20
        static void WriteEvens(int a, int b)
        {
            for (int i = a; i <= b; ++i)
            {
                if (20 == i)
                {
                    break;
                }
                if (1 == i %2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        // const is static so you don't need to call it static.
        const float CostOfItem = 2.75f;

        static float FindCost(int n)
        {
            return n * CostOfItem;
        }

        static void Main(string[] args)
        {
            /* C# Fundamentals, Part 2
             * 
             * Functions and Methods are the same thing in C# every Function belongs to a class.
             * Review Hypotenuse - Functions go in Program - Call in Main.
             * 
             * Control Flow: Language features that can direct the execution of a program - if, else, elseif
             * A function can only execute one return.
             * 
             * Loops!!!
             * for, do-while, while
             * 
             */

            //Console.WriteLine(Hypotenuse(-3, 4));
            //Console.WriteLine(Hypotenuse(3, 4));

            // For loop:
            // syntex - variable (what you are iterating on; condition (keep looping while this condition is not meet); action (what to do!)

            //for (int i = 0; i < 11; ++i)
            //{
            //    Console.WriteLine(i);
            //}

            // While loop and Do-while:
            // syntex while - 

            //int i = 0;

            // This starts at 0 and goes to 10.

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    ++i;
            //}

            // This does 1 - 10 not starting with 0.

            //while (++i < 11)
            //{
            //    Console.WriteLine(i);
            //}

            // This takes it up to 11.

            //while (i++ < 11)
            //{
            //    Console.WriteLine(i);
            //}

            // syntex do-while - this is the only loop that is guarenteed to execute at least once.

            //do
            //{
            //    Console.WriteLine(i);
            //    ++i;
            //} while (i < 11);

            // Continue and Break:
            // See function above

            //WriteEvens(1, 10);
            //WriteEvens(1, 30);

            // Const:
            // Define a variable that shouldn't change, if this the case use const.
            // Const needs to have a type and must be initialized as soon as it is declared. 
            // Magic numbers - should be avoid and const should be used instead. They are literal numbers that exist without any identification of what they are for.
            // see example above.

            //Console.WriteLine(FindCost(1));

            // Casting:
            // C# can try to implicity convert one type to another. Also see in review notes. 

            int x = 3;
            float y = 2.4f;
            float val = (float)x * y;



        }
    }
}
