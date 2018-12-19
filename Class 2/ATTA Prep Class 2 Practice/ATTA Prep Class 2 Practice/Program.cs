using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_2_Practice
{
    class Program
    {
    // Ex. 1 - Write a function that, given a positive integer 'n' as input,
    // returns the average of all integers from 1 through 'n', inclusive.
    
        static float AverageOfRange(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return -1;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i <= n; ++i)
                {
                    sum = sum + i;
                    //Console.WriteLine("Print debugging: our current sum is" + sum);
                }
                return sum / n; 
            }
           
        }

    // Ex. 2 - Write a function that determines how many positive integers 
    // from 1 through a given 'n', inclusive, are divisible by 3. 
    // Return the results.

        static int DivisibleByThree(int n)
        {
            int count = 0;
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return -1;
            }
            else
            {
                for (int i = 1; i <= n; ++i)
                {
                    if (0 == i % 3)
                    {
                        ++count;
                        Console.WriteLine(i + " is divisible by 3.");
                    }
                }
                return count;
            }
        }

    // Ex. 3 - Write a function that determines whether or not a given float
    // value lies wihtin the range of -2.7f through 5.8f, inclusive.
    // Return 'true' if yes, 'false' if no. Avoid Magic Numbers!!

        static bool isInRange(float a)
        {
            const float lowerLimit = -2.7f;
            const float upperLimit = 5.8f;
            if (a >= lowerLimit && a <= upperLimit)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }


    // Ex. 4 - Write a function that writes to the console a series of 
    // (x, y) coordinates. 
    // e.g: (1, 1) (1, 2) (1, 3) (2, 1) (2, 2) ... (3, 3)
    // Hint: Use nested loops to do this.

        static void PrintCoords(int x, int y)
        {
            for (int iX = 1; iX <= x; ++iX)
            {
                for (int iY = 1; iY <= y; ++iY)
                {
                    Console.WriteLine("(" + iX + ", " + iY + ")");
                }
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine(AverageOfRange(5));
            Console.WriteLine(AverageOfRange(0));
            Console.WriteLine(AverageOfRange(-5));
            Console.WriteLine(AverageOfRange(10));

            Console.WriteLine(DivisibleByThree(10));
            Console.WriteLine(DivisibleByThree(-1));
            Console.WriteLine(DivisibleByThree(0));
            Console.WriteLine(DivisibleByThree(15));

            Console.WriteLine(isInRange(-1.5f));
            Console.WriteLine(isInRange(-75f));
            Console.WriteLine(isInRange(1.4f));
            Console.WriteLine(isInRange(75f));

            PrintCoords(3, 3);
            PrintCoords(4, 7);
            PrintCoords(5, 2);

        }
    }
}
