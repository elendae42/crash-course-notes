using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_2___Homework___Flow_Ctrl
{
    class Program
    {
        // Functions and Control Flow

        // Ex. 1. Write a function that takes three floats as input.
        // Return true if all three values are positive; return false if any of them are zero or negative.

        static bool ThreePositive(float x, float y, float z)
        {
            if (x > 0f && y > 0f && z > 0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    

        // Ex. 2. Write a function that takes three characters as input.
        // The function should write the three characters to the console in alphabetical order. 
        // HINT: It may be helpful to convert all characters to lower-case to deal with mixed input.
        // You can do this with the char.ToLower() function. Here’s an example of how to use it:

        //char c = ‘A’          // c is initialized to an upper-case ‘A’
        //c = char.ToLower(c)        // This will change c to a lower-case ‘a’
        
        static void ThreeAlpha(char a, char b, char c)
        {
            a = char.ToLower(a);
            b = char.ToLower(b);
            c = char.ToLower(c);

            for (char i = 'a'; i <= 'z'; ++i)
            {
                if (i == a)
                {
                    Console.Write(a + " ");
                }
                if (i == b)
                {
                    Console.Write(b + " ");
                }
                if (i == c)
                {
                    Console.Write(c + " ");
                }
            }
            Console.WriteLine(" ");
        }

        // Ex. 3. Write a function that prints the numbers 1 through 10, inclusive, to the console.
        // Modify the function so that it does this five times in a row.

        static void PrintNumbers(int min, int max, int times)
        {
            int x = 1;
            while (x <= times)
            {
                ++x;
                for (int i = min; i <= max; ++i)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
            }
        } 

        // Ex. 4. Write a function that, given the floating-point width and length of a rectangle, returns the area.
        // If the function is called with invalid input 
        // (e.g., if either value is less-than or equal-to zero) 
        // then print a warning message to the console and return 0f.

        static float RectangleArea(float side1, float side2)
        {
            if (side1 > 0f && side2 > 0f)
            {
                return side1 * side2;
            }
            else
            {
                Console.WriteLine("Invalid Input - requires positive numbers greater than 0.");
                return 0f;
            }
        }




        // Ex. 5. Write a function that, given the floating-point radius of a circle, 
        // returns the approximate area of the circle.
        // Use the value 3.14 to approximate the constant pi.
        // Avoid magic numbers!

        static float CircleArea(float radius)
        {
            const float pi = 3.14f;
            if (radius > 0f)
            {
                return pi * (radius * radius);
            }
            else
            {
                Console.WriteLine("Invalid Input - Radius must be a positive number greater than 0.");
                return 0f;
            }
        }


        // Ex 6. Complete the following function:
        //static void PrintWithDecoration(string message, char ornament, int count)
        //{
        // Some code goes here…
        //}


        // The function should print the string ‘message’ to the console with a decoration on either side.
        // The decoration should be comprised of ‘ornament’ repeated ‘count’ times.
        // So the following call:
        //PrintWithDecoration(“Hello”, ‘*’, 5)
        // Should print the following to the console:
        //*****Hello*****
        
        static void PrintWithDecoration(string message, char ornament, int count)
        {
            for (int i = 1; i <= count; ++i)
            {
                Console.Write(ornament);
            }
            Console.Write(message);
            for (int i = 1; i <= count; ++i)
            {
                Console.Write(ornament);
            }
        }


        // Ex. 7. Write a function that, given a range of positive integers, 
        // returns the first one that is both odd and divisible by seven. 
        // You can use the remainder operator ‘%’ to help you with this. 
        // If there is no valid return value in the supplied range, return 0.



        // Ex. 8. Imagine you own a shop that sells widgets. 
        // Each widget costs $2.00 to manufacture, and will be sold for $3.50. 
        // Write functions with the following names to perform the given tasks 
        // (in each case use floating-point numbers to represent dollar amounts, e.g., $3.50 can be represented as 3.5f):

        // TotalCost: Determine the total cost of manufacturing n widgets.
        // GrossProfit: Determine the gross profit of n widgets sold 
        //(i.e., the total amount of money you’ll make in sales minus the total cost of manufacturing the widgets.)
        // RequiredWidgets: Given a floating point number that represents a gross target profit,
        // determine the minimum number of widgets that will need to be sold to achieve the target profit.




        


        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Results for Ex. 1.");
            Console.WriteLine(ThreePositive(2.3f, 1.3f, .01f));
            Console.WriteLine(ThreePositive(-2.3f, 1.3f, .01f));
            Console.WriteLine(ThreePositive(2.3f, 0f, .01f));

            // Exercise 2
            Console.WriteLine("Results for Ex. 2.");
            ThreeAlpha('E', 'r', 's');
            ThreeAlpha('E', 'A', 's');
            ThreeAlpha('u', 'U', 'a');
            ThreeAlpha('T', 'H', 'x');
            ThreeAlpha('B', 'b', 'f');

            // Exercise 3
            Console.WriteLine("Results for Ex. 3");
            PrintNumbers(1, 10, 5);
            PrintNumbers(10, 30, 2);

            // Exercise 4
            Console.WriteLine("Results for Ex. 4");
            Console.WriteLine(RectangleArea(0.1f, 5.2f));
            Console.WriteLine(RectangleArea(0f, 2f));
            Console.WriteLine(RectangleArea(5.5f, 2.3f));
            Console.WriteLine(RectangleArea(-6.3f, -2f));

            // Exercise 5
            Console.WriteLine("Results for Ex. 5");
            Console.WriteLine(CircleArea(4f));
            Console.WriteLine(CircleArea(-7F));
            Console.WriteLine(CircleArea(0f));

            // Exercise 6
            PrintWithDecoration("Hello World", '*', 5);

            //Ex. 8:
            // Check your functions against the following input / output:
            //TotalCost(20)  // Should return 40f
            //GrossProfit(30) // Should return 45f
            //RequiredWidgets(50.00f)             // Should return 34


            // Now change the cost of each widget to $1.75 and the sale price to $4.15. The new outputs should be:
            //TotalCost(20)  // Should return 35f
            //GrossProfit(30) // Should return 72f
            //RequiredWidgets(50.00f)             // Should return 21
        }
    }
}
