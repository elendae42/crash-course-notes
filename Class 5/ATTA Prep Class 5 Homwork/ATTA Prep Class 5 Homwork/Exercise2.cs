using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Homwork
{
    class Exercise2
    {
        //Ex. 2. Create a function that accepts a string as input and outputs an encrypted version of the string. Each character in the original string should be explicitly converted to an integer,          decremented by 1, and converted back into a character. Additionally, the characters in the new string should be in reverse order compared to the original string (try using a Stack for this.) For    example, if the input is “Penguin” then the output string should be “mhtfmdO”. Each letter has been shifted down by one and the entire string is reversed.

        //Ex. 3. Follow-up: Write a decryption function that, given a string encrypted using the function in Ex. 2, will return a decrypted string. If we give this function “mhtfmdO” as input it should      output “Penguin”. 

        private static string operation;

        public static string operationChoice()
        {
            string choice = "null";
            while (choice == "null")
            {
                Console.WriteLine("Would you like to: \n (1) Encode a word or phrase \n (2) Decode a word or phrase");
                Console.Write("  ->  ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    return operation = "encode";
                }
                else if (choice == "2")
                {
                    return operation = "decode";
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    choice = "null";
                    return null;
                }
            }
            return operation;

        }

        public static string userWord()
        {

            Console.Write("Please input a word or phase to {0}: ->  ", operation);
            string wordChoice = Console.ReadLine();
            return wordChoice;
        }

        public static void encrypt(string uWord)
        {
            Stack<int> encipher = new Stack<int>();
            foreach(char c in uWord)
            {
                int i = Convert.ToInt32(c) - 1;
                encipher.Push(i);
            }
            foreach(int x in encipher)
            {
                char en = Convert.ToChar(x);
                Console.Write(en);
            }
            Console.WriteLine("");
        }

        public static void decrypt(string uWord)
        {
            Stack<int> decipher = new Stack<int>();
            foreach (char c in uWord)
            {
                int i = Convert.ToInt32(c) + 1;
                decipher.Push(i);
            }
            foreach (int x in decipher)
            {
                char en = Convert.ToChar(x);
                Console.Write(en);
            }
            Console.WriteLine("");
        }

    }
}
