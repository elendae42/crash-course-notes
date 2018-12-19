using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise10
    {
        // Ex. 10. Write a simple encryption function.Given a string as input, the function should return a new string that shifts each letter up by one.For example:
        //          “apple” becomes “bqqmf”

        // Assume all input will be in lower-case letters with no numbers or special characters. The character ‘z’ should wrap around and become ‘a’. 

        // HINT: Characters are very closely related to integers and can be converted to integers and manipulated with mathematical operations. Try doing some research to learn how.
        private static string operation;

        public static char[] alphabet = new char[26]
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        public static string testString = "lafluiwoywpadufhsnbvswvndzqdufrbpluyqplwlphzrluedubsymiprdijhtyqucucylkfrskhzbuhuluerpqfoylyssamwocwhzolgdtddppofddtgopyudgwoyosdrykvvdvlaulrzygwpljzyqkyptwvljiafhhswomuvddaplmjluepvlrnpdwfxwmqafhzseqcfagqdfljflhldswclmqlfxubulbdubvpvwfqhwyuhrhjgsocuzzxagfvlilqvafdarkpqlzcqaguljbuczampl";

        public static  void operationChoice()
        {
            string choice = "null";
            while (choice == "null")
            {
                Console.Write("Would you like to: \n (1) Encode a word or phase \n (2) Decode a word or phrase");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    operation = "encode";
                }
                else if (choice == "2")
                {
                    operation = "decode";
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    choice = "null";
                }
            }

        }

        public static string userWord()
        {
            
            Console.Write("Please input a word or phase to {0]: ->  ", operation);
            string wordChoice = Console.ReadLine();
            return wordChoice;
        }

        public static string keyWord()
        {
            Console.Write("Please enter a key for your Cypher: ->  ");
            string keyChoice = Console.ReadLine();
            return keyChoice;
        }

        public static string encode(string toEncode, string key)
        {
            string encoded = ("not yet implemented");
            return encoded;
        }

        static public int countDistance(char start, char end)
        {
            int count = 0;
            int pos = alphabet[start];
            while (alphabet[pos] != end)
            {
                count++;
                pos++;
                if (pos >= alphabet.Length)
                {
                    pos = 0;
                }
            }
            return count;
        }

        public static string decode(string toDecode, string key)
        {
            int keyPos = 0;
            string decoded;
            foreach (char i in toDecode)
            {
                char keyChar = key[keyPos];
                int decodePos = countDistance(keyChar, i); 
            }

        

       
		#print("Decoded character is", alphabet[decodedPos-1])
		result += alphabet[decodedPos - 1]

        keyPos += 1

        if (keyPos >= len(key)):
			keyPos = 0


    print("Decoded string is ", result)


            
            return decoded;
        }






    }
}
