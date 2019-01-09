using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_3_Homework
{
    class Program
    {
        static Employee employee1 = new Employee("Luna", "Lovegood", "Editor and Chief, Quibbler");
        static Employee employee2 = new Employee("Ginny", "Molly", "Potter", "Senior Quidditch Correspondent");
        static Employee employee3 = new Employee("Harry", "James", "Potter", "Department Head, Auror Office");
        static Employee employee4 = new Employee("Hermione", "Jane", "Weasley", "Lawyer");
        static Employee employee5 = new Employee("Ronald", "Bilius", "Weasley", "Auror");
        static Employee employee6 = new Employee("Neville", "Longbottom", "Healer");

      
        static void Main(string[] args)
        {

            // Creating and using classes
            // NOTE: Exercises 1 – 8 all incrementally build on the same class and should be completed in order.
            //Ex. 1. Create a class called Employee that represents an employee record. Provide the class with three public fields: A string for the employee’s name, a string for a job title, and a uint for an identification number. In the Main function create an instance of an Employee and set its fields to any data you like. Write these various fields to the console.
            employee1.printEmployee();
            employee2.printEmployee();
            employee3.printEmployee();
            employee4.printEmployee();
            employee5.printEmployee();
            employee6.printEmployee();

            // Ex. 2. Change the identification field’s access modifier to private and initialize it with 0. Add a property to your class that allows you to get and set the ID field’s value.



            // Ex. 3. Return to the property you created in Ex. 2. Add an invariant by modifying the set accessor so that an employee ID can never be greater than 1000.



            // Ex. 4. Add a constructor to your Employee class that allows you to initialize a new Employee with a name, job title, and ID.Within your constructor, assign the name and job title fields directly from the input provided to the constructor.Assign the ID argument to the property you created in Ex. 3 (think about why this is a better approach than simply assigning directly to the field.)



            // Ex. 5. Add another constructor to your Employee class that takes no arguments and initializes the three fields to default values of your choice.In the Main function try instancing Employees using both constructors to get a feel for the difference.Create additional constructors if you want more practice!



            // Ex. 6. Add a public method to the Employee class that provides a report on the employee.It should write the Employee’s name, job title, and ID to the console.Try instancing an Employee in Main and calling its reporting method. Bonus: If you are using Visual Studio 2015 or later, use string interpolation to simplify the string you write to the console(see the research section above for a link on how to do string interpolation.)



            // Ex. 7. In Ex. 3., we created an invariant that prevents Employee IDs from being greater than 1000. If you wrote your set accessor in such a way that the number 1000 appears in the code, you have a magic number! We should try to fix that.Create a static uint field and initialize it with the value 1000. Modify your property so that, instead of checking against the integer literal 1000, it checks against your new static field. (Bonus research: Try to make your field both static and const. Does this work? If not, try to determine why!)



            // Ex. 8. Back in your Program class, create a static function that takes two Employees as input and writes the name of the employee with the higher ID number to the console.If both Employees have the same ID, write a warning to the console that this is the case.



            // Ex. 9. Think of things in the real world (or in fantasy worlds!) that you can represent with classes, then try to implement simple versions of them.Don’t be afraid to experiment by adding constructors, methods, fields, properties, and static members as necessary.Here are a few ideas to get you started:
            // •	A class representing a Rectangle.Each Rectangle should have a floating-point width and height. These fields should be private; create properties to allow read-write access to them, but don’t allow either dimension to be less-than or equal-to zero.Provide a method that calculates and returns the area of the Rectangle.
            // •	A class representing a dog.The Dog class should have private fields for breed, coat color, and name.Initialize all these fields with a constructor, then allow read-only access to them with properties.Feel free to create a Cat class instead if you prefer(or both if you’re industrious!)
            // •	A Hero class representing a player avatar in an RPG.The Hero should have a level, experience points, and stats for strength, intelligence, and wisdom. These stats should be initialized by a constructor, but every Hero should start at Level 1 with no experience. Add a method that adds a given amount of experience to the hero.Every time a Hero gains 500 experience points its level should go up and its stats should increase by 5.
            // •	A class representing a Bridge.Provide fields representing various dimensions and one or more constructors to initialize them. Add properties for access and add invariants as you see fit.Add a read-only field / property describing the maximum weight the bridge can support before collapsing.
            // •	Bonus: Now create a Car class that contains, among other things, a weight that can be accessed via a property. Write a function in your Program class that, given a Bridge and a Car, returns true if the car can safely cross the bridge, and false if not!


        }
    }
}
