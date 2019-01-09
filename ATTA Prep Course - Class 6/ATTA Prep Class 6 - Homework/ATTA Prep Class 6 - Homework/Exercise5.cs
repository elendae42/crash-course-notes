using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise5
    {
        //Ex. 5. Write a function that function that, given an integer n as input, returns a list of all prime numbers from 2 through n, inclusive.

        public static int userNumber;
        public static void userInput()
        {
            Console.Write("Please input a number to see all prime numbers upto and including that number:  ->   ");
            userNumber = Int32.Parse(Console.ReadLine());
        }
        public static List<int> primeList(int uNum)
        {
            List<int> Primes = new List<int>();
            for (int i = 0; i <= uNum; ++i)
            {
                if (getPrimes(i) == true)
                {
                    Primes.Add(i);
                    
                }
            }
            return Primes;
        }

        public static bool getPrimes(int i)
        {
            if ((i == 0) || (i == 1))
            {
                return false;
            }
            else if (i == 2)
            {
                return true;
            }
            else if (i % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int j = 3; j < i; ++j)
                {
                    if (i % j == 0)
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                return true;
            }
            
        }
    }
}
