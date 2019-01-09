using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_4___Homework
{
    class Exercise6
    {

        // Ex. 6. Create a class that represents a student. Provide the class with a field to represent the student’s name and a private list of floating-point point values to represents the student’s grades. Provide the class with an AddGrade(float) method that allows you to add a grade to the student’s grade list, and a GradeAverage() method that returns the student’s current average score.

        // Ex. 7. Bonus: Add a GPA() method to the above class that returns the student’s grade point average based on the average grade.


        public Exercise6(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        public Exercise6()
        {

        }
       
        // Fields for Student
        private string firstName;
        private string lastName;
        private List<float> grades = new List<float>();

        // GPA Ranges
        private static float gradeA = 4f;
        private static float gradeB = 3f;
        private static float gradeC = 2f;
        private static float gradeD = 1f;
        private static float gradeF = 0f;

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public void addGrades(float a)
        {
            {
                if (a < 0f)
                {
                    grades.Add(0f);
                }
                else
                {
                    grades.Add(a);
                }               
            }
        }
        public void addGradesManaul()
        {
            Console.Write("How many grades do you need to enter? ->  ");
            int entering = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < entering; ++i)
            {
                Console.Write("Please enter grade in decimal format (example 85.5): ->  ");
                float grade = float.Parse(Console.ReadLine());
                if (grade < 0f)
                {
                    grades.Add(0f);
                }
                else
                {
                    grades.Add(grade);
                }
            }
        }
        public List<float> Grades
        {
            get
            {
                return grades;
            }
        }
        public void gradeDebug()
        {
            foreach (float i in grades)
            {
                Console.WriteLine("Grade is {0}", i);
            }
        }
        
        public float gradeAverage(List<float> grades)
        {
            return grades.Average();
        }

        public float studentGPA(List<float> grades)
        {
            float sGPA = 0f;
            foreach (float i in grades)
            {
                if (i < 60f)
                {
                    sGPA = sGPA + gradeF;
                    
                }
                else if ((i > 60f) && (i <70f))
                {
                    sGPA = sGPA + gradeD;
                    
                }
                else if ((i > 70f) && (i < 80f))
                {
                    sGPA = sGPA + gradeC;
                    
                }
                else if ((i > 80f) && (i < 90f))
                {
                    sGPA = sGPA + gradeB;
                   
                }
                else 
                {
                    sGPA = sGPA + gradeA;
                    
                }
                
            }
            return sGPA / grades.Count;
        }




    }
}
