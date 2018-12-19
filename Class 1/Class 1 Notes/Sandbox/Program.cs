using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using is similar to Import in Python and allows you to use pre-existing libraries in your program.

namespace Sandbox
    // program name
{
    class Program
        // Class
        
               
    {
        static float SignChange(float val) // functions have to parts - this is the prototype/signature anything in the curly braces is the definition. If you put a ';' at the end here you will not be able to use it until you define it.
        {
            val *= -1f; // val will be multipled by -1
            return val; // return is what will be spit out the other end of the function. 

            // Another way to write this is- return val * -1f;
        }

        static float Average(float x, float y)
        {
            float sum = x + y;
            float average = sum / 2f; // if you are working with floating point values want to keep this consistant so that we don't have to worry about things changing on us. So use the F.
            return average;
        }

        static void Main(string[] args) // This is where the program starts excution
            // variables - variable names should clear, readable, and preferably easy to type. We usually start variables wtih a lower-case letter but C# doesn't actually care. 
            // The coding covention you use will be defined by your team. :)

            // Common Types of Variables:
            // int - Integer value with in given range
            // long - is a bigger integer
            // float - Single-precision floating point number - decimels
            // double - Double-precision floating point number
            // char - a single character
            // bool - true/false
            // string - A group of characters
            // var - an unspecified type that must be deduced by the compiler
        {
            // Code goes here!! 

            Console.WriteLine("Hello World! "); // This is the Hello World program.
            // Common Console. stuff:
            // Write - writes a text line to the console
            // WriteLine - like write but with a line terminator
            // Read - Read Text from the console
            // ReadLine - reads user imput

            // Strongly Typed Language and Variables  

            int iCooldown = 0; // declaring a variable means naming it; intializing is assigning a value, in this case 0. - it is not require to intialize a variable when it created but it is good practice to do so.

            // Stuff happens here! And now we can change the variable value. 
            iCooldown = iCooldown - 1;

            Console.WriteLine(iCooldown); // Writes what is stored in the iCooldown variable.
            
            // Let's play with some variable types

            float fDecimalNumber = 10.4f; // use the f suffix to create a literial of this type. If you don't put the f it will assume a double-precision float.

            bool bHasExecutedWithoutError = true; // Bool can also take 0,1 for true/false but it is not preferred to use that but it is not off the table

            var i = 3; // var? this can be any type of variable and we let what is assigned to decide it's type - and they must be intialized at the time of creation. 
            
            // Operators:
            // = commonly used for assignment
            // >,<, == Comparisons greater than , less than, equal to
            // && for and to create more complex comparisons
            // || for or to create more complex comparisons
            // computations + - * /

            string sMyName = "ShaunnaRoche";

            int x = 3;
            int y = 7;
            int z = 5 * 7;
            char c = '!'; // single quotes are for type char
            string s = "Hello"; // double quotes are for type string

            Console.WriteLine(x == 3); // simple comparison
            Console.WriteLine(x == 3 && c == '!'); // (3 == x && '!' == c) also works "Yoda sentax" and can prevent error of missing an equal sign.

            //Maths! and short hands
            // to increase something by a value you can use +=, *=, ect . to increment/decremnt short hand ++, --
            Console.WriteLine(z); //writes z
            Console.WriteLine(s);

            /* Functions:
             * Functions are the building blocks - it is a bit of code that performs a specific task for the rest of the program.
             * They are usually defined at the top of the program. See SignChange for example.
             * Functions have to be declared and defined in a specific way:
             * 
             * Modifier   -  Output  -   Name (Input/arguments)
             * Static     -  int     -   TakeDamage (int damage)
             */

            // Calling the function!

            Console.WriteLine(SignChange(-7.5f)); // -7.5f is the argument we are passing in and is a float. You will get an error without the F.

            // Scope - Namespace, Class, Functions all have their own scope. A variable is usually only good with in it's own scope. 
            // Declaring local vs global - if variable is declared in main global if in aother function it is local to that function it will be cleaned up once the function is exited.

            // Flow control next time. 

            // Homework = will come by email! Video will be up as well. Keep practicing - start rewriting DnD 3.5 character generator in C# as a personal project. 
        }
    }
}
