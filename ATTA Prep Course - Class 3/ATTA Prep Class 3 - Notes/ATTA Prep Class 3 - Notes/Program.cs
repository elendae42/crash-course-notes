using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_3___Notes
{
    class Program
    {
       

        static void Main(string[] args)
        {

            /* Classes!!!
             * + static, public, private etc. 
             * A class is a way of organizing state or data and functions/methods.
             * Once you define a class, you can then create an instances of a class. These are sometimes referred to as "objects."
             * A class is a blueprint for the object you want to create - the object/instance is the thing you created. 
             * 
            */
            // Class for car Blue print. Classes go in the Namespace and classes can go in sepreaete files - Project - Add class. In this case Car.cs

            // Access Modifiers -
            // The individual data members of a class are called fields and they have differnent levels of access.
            // Public - are accessible to any other part of the program and you can view/change them at will
            // Private - are hidden and are only accessible from within the class itself. This is the default access level for any field in a class.
            // if you leave it blank you will get private.
            // It is not usually a good idea to give unrestricted access to an objects state. 
            // There is special language feature that helps us manage an object's state: the property.
            // Property - specialized function that allows you to set rules regarding how a state is accessed and changed
            // We us special accessor to control this.
            // Static - static field method or property belongs to the class not any specific instance. 

            //Car car1 = new Car();
            //car1.m_Name = "Mitsubishi Lancer";
            //car1.m_Year = 2014;
            //car1.m_Color = "Silver";
            //car1.Report();

            Orc orc1 = new Orc();
            //Console.WriteLine(orc1.OrcID);
            Console.WriteLine(orc1.MaxHp);
            Console.WriteLine(orc1.CurrentHp);
            orc1.CurrentHp -= 1000;
            Console.WriteLine(orc1.CurrentHp); // current Hp should be 0
            orc1.CurrentHp += 1000;
            Console.WriteLine(orc1.CurrentHp); // current Hp should be 50
            Console.WriteLine(Orc.Warcry);

            //Orc orc2 = new Orc();
            //Console.WriteLine(orc2.OrcID);
            //Orc orc3 = new Orc();
            //Console.WriteLine(orc3.OrcID);
            //Orc orc4 = new Orc();
            //Console.WriteLine(orc4.OrcID);
            //Orc orc5 = new Orc();
            //Console.WriteLine(orc5.OrcID);


            /* Constructors- 
             * Allows you to create objects with initialzation data of your choice. 
             * 
             */

            // Ex 5.
            // Modify your constructors to provide every Orc with a unique indentifying integer. How might we accomplish this?




            

        }
    }
}
