using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Program
    {
        static Exercise6 studentChi = new Exercise6("Chi", "Yamada");

        private static void exerciseList()
        {
            Console.WriteLine("Please select which exercise you would like to see:\n");
            Console.WriteLine(
                " 1. Declare an array of 50 integers. Assign each item in the array to consecutive multiples of 5,\n    starting with 5.\n");
            Console.WriteLine(
                " 2. Write a function that, given an array of strings as input, prints out the length of each string.\n    If you need help, do some research on strings to learn how to determine their length.\n");
            Console.WriteLine(
                " 3. Modify the function in Ex. 2 to return the length of the longest string (or strings, it there\n    are ties) in the array.\n");
            Console.WriteLine(
                " 4. Write a function that, given a string as input, returns a new string that reverses the\n    characters of the input string.\n");
            Console.WriteLine(
                " 5. Write a function that, given a two-dimensional array of integers, returns the sum of every\n    integer in the array.\n");
            Console.WriteLine(
                " 6. Create a class that represents a student.Provide the class with a field to represent the\n    student’s name and a private list of floating-point point values to represents the student’s\n    grades. Provide the class with an AddGrade(float) method that allows you to add a grade to the\n    student’s grade list, and a GradeAverage() method that returns the student’s current average\n    score.\n");
            Console.WriteLine(
                " 7. Bonus: Add a GPA() method to the above class that returns the student’s grade point average\n    based on the average grade.\n");
            Console.WriteLine(
                " 8. Write a function that, given a list of integers, returns a new list that contains all of the\n    even integers in the input list.\n");
            Console.WriteLine(
                " 9. Write a function that, given a list of integers, returns a new list that contains all of the\n    even integers in the input list.\n");
            Console.WriteLine(
                " 10. Write a simple encryption function.Given a string as input, the function should return a new\n    string that shifts each letter up by one.\n");
            Console.WriteLine(
                " 11. Write a function that takes two lists of strings as input.The function should read each string\n    in the second list and, if there are any instances of that string in the first list, remove them.\n");
            Console.WriteLine(
                " 12. Write a function that, given two strings as input, determines whether or not the first string\n    contains the second string.\n");
            Console.Write(" Please select a number ->  ");
        }

        static string selectExercise()
        {
            exerciseList();
            string userChoice = "null";
            while (userChoice == "null")
                {
                userChoice = Console.ReadLine();
                if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3") || (userChoice == "4") || (userChoice == "5") || (userChoice == "6") || (userChoice == "7") || (userChoice == "8") || (userChoice == "9") || (userChoice == "10") || (userChoice == "11") || (userChoice == "12"))
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

        static void getExercise(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    int userNumber = Exercise1.chooseNumber();
                    Exercise1.homeworkEx1(userNumber);
                    Exercise1.printEx1();
                    break;
                case "2":
                    Exercise2.addElement();
                    Exercise2.wordLength(Exercise2.sArray);
                    break;
                case "3":
                    Exercise3.addElement();
                    int wordLength = Exercise3.longestWord(Exercise3.sArray);
                    Console.WriteLine("The longest work is {0} letters.", wordLength);
                    break;
                case "4":
                    string pickedWord = Exercise4.userWord();
                    int pickedLength = Exercise4.wordLength(pickedWord);
                    // Console.WriteLine("Your word {0} is {1} letters long.", pickedWord, pickedLength); // This is print Debugging
                    Exercise4.wordReversed(pickedWord, pickedLength);
                    break;
                case "5":
                    int rows = Exercise5.rows();
                    int columns = Exercise5.columns();
                    int[,] map = new int[rows, columns];
                    Exercise5.testArray(map);
                    Exercise5.addArray(map);
                    break;
                case "6":
                    // Class for Exercise 6 instanced at top
                    studentChi.addGradesManaul();
                    float averageChi = studentChi.gradeAverage(studentChi.Grades);
                    studentChi.gradeDebug();
                    Console.WriteLine(" Student Name: {0} {1} \n Current Average {2}", studentChi.FirstName, studentChi.LastName, averageChi);
                    break;
                case "7":
                    // This is an extension of Ex 6 and will use the same class/instance.
                    studentChi.addGradesManaul();
                    float chiGPA = studentChi.studentGPA(studentChi.Grades);
                    Console.WriteLine(" Student Name: {0} {1} \n Current GPA {2}", studentChi.FirstName, studentChi.LastName, chiGPA);
                    break;
                case "8":
                    int first = Exercise8.firstNumber();
                    int second = Exercise8.secondNumber();
                    Exercise8.addNumbers(first, second);
                    List<int> evens = Exercise8.evensOnly(Exercise8.numbers);
                    Exercise8.printList(evens);
                    break;
                case "9":
                    // This exercise is an extension of Ex 8 and will use the same class.
                    int firstOdd = Exercise8.firstNumber();
                    int secondOdd = Exercise8.secondNumber();
                    Exercise8.addNumbers(firstOdd, secondOdd);
                    List<int> odds = Exercise8.oddsOnly(Exercise8.numbers);
                    Exercise8.printList(odds);
                    break;
                case "10":
                    //         Build testing / Error Checking. 
                    //Console.WriteLine("pvlrnpdwf with key dhy = monograph");
                    //string encoded = Exercise10.encode(Exercise10.testString2, "dhy");
                    //string decoded = Exercise10.decode(Exercise10.testString3, "dhy");
                    //string decoded2 = Exercise10.decode(encoded, "dhy");
                    //Console.WriteLine("Encode {0}", encoded);
                    //Console.WriteLine("Decode {0}, {1}", decoded, decoded2);

                    string choice = Exercise10.operationChoice();
                    string userword = Exercise10.userWord();
                    string key = Exercise10.keyWord();
                    Exercise10.runChoice(choice, userword, key);
                    break;
                case "11":
                    Exercise11.pruneList(Exercise11.list1, Exercise11.list2);
                    Exercise11.printList(Exercise11.list1);
                    break;
                case "12":

                    Console.WriteLine("Not yet implemented");
                    break;
            }
        }
	




    static void Main(string[] args)
         {
            Console.SetWindowSize(160, 40);
            string userChoice = selectExercise();
            getExercise(userChoice);
            Console.ReadKey();

            //Ex. 12. Write a function that, given two strings as input, determines whether or not the first string contains the second string. For example, given “abcdefg” as the first string and “cde” as the second string, the function should return true, because the first string contains “cde.”

        }
    }
}

