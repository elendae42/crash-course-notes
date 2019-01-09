using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_6___Homework
{
    class Exercise3
    {
        //Ex. 3. Write a function that, given an integer as input, returns a List<int> of all the distinct prime factors of the input integers.For example:
        //    Input: 10	Output List: 2,5
        //    Input: 60	Output List: 2,3,5
        //    Input: 19	Output List: 19

        public static List<int> primeFactors(int num)
        {
            List<int> primeFactor = new List<int>();
            for(int i = 1; i <= num; ++i)
            {
                int test = num % i;
                if(test == 0)
                {
                    bool check = isPrime(i);
                    if (check == true)
                    {
                        if (primeFactor.Contains(i))
                        {
                            break;
                        }
                        else
                        {
                            primeFactor.Add(i);
                        }
                    }

                }
            }
            return primeFactor;
        }
        public static bool isPrime(int num)
        {
            bool prime = false;
            if(num == 0)
            {
                prime = false;
            }
            else if (num == 1)
            {
                prime = false;
            }
            else if (num == 2)
            {
                prime = true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < num; ++i)
                {
                    prime = factorTest(num, i);
                    if (prime == false)
                        return prime;
                }
            }
            return prime;
        }
        public static bool factorTest(int num, int i)
        {
            if (num % i == 0)
            { 
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

