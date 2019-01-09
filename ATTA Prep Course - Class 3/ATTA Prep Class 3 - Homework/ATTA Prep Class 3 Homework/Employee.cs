using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_3_Homework
{
    class Employee
    {
        //Ex. 1. Create a class called Employee that represents an employee record. Provide the class with three public fields: A string for the employee’s name, a string for a job title, and a uint for an identification number. In the Main function create an instance of an Employee and set its fields to any data you like. Write these various fields to the console.

        // Ex. 2. Change the identification field’s access modifier to private and initialize it with 0. Add a property to your class that allows you to get and set the ID field’s value.

        // Ex. 3. Return to the property you created in Ex. 2. Add an invariant by modifying the set accessor so that an employee ID can never be greater than 1000.

        static private int employeeIDCounter = 1;
        private string firstName = "null";
        private string middleName = "null";
        private string lastName = "null";
        private string jobTitle = "null";

        // Constructors

        public Employee(string fName, string lName, string jTitle)
        {
            FirstName = fName;
            LastName = lName ;
            JobTitle = jTitle;
            AssignID();
            
        }
        public Employee(string fName, string mName, string lName, string jTitle)
        {
            FirstName = fName;
            MiddleName = mName;
            LastName = lName;
            JobTitle = jTitle;
            AssignID();
        }



        // Fields and Accessors:

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

        
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
               middleName = value;
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
        
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        private int employeeID;
        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                if (value <= 0)
                {
                    employeeID = 1000000;
                    Console.WriteLine("Error in employee data - Employee Id must be greater than 0.");
                }
            }
        }

        // Method
        private void AssignID()
        {
            employeeID = employeeIDCounter++;
        }

        public void printEmployee()
        {
            if (MiddleName == "null")
            {
                Console.WriteLine("Employee Name: {0} {1}", FirstName, LastName);
                Console.WriteLine("Job Title: {0}", JobTitle);
                Console.WriteLine("Employee Id Number: {0}\n", EmployeeID);
            }
            else
            {
                Console.WriteLine("Employee Name: {0} {1} {2}", FirstName, MiddleName, LastName);
                Console.WriteLine("Job Title: {0}", JobTitle);
                Console.WriteLine("Employee Id Number: {0}\n", EmployeeID);
            }
        }
    }
}
