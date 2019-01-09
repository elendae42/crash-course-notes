using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_5_Homwork
{
    class Exercise7
    {
        /* Ex. 7. BlizzCon is almost upon us, and your task is to create a class called TicketVendor that ensures that early buyers get BlizzCon tickets. Modify the Person struct in Ex. 1. and provide it with a public bool field called “hasTicket”. Provide your TicketVendor class with a private Queue<Person> called “ticketQueue” and a private List<Person> called “completedList.” Now provide your class with the following public methods:
            •	AddPerson - Add Persons to the queue. You might want to provide your Person struct with a constructor to make this a little easier.
            •	TryTicket - Attempt to give a Person in the queue a ticket. Since there are only 5 BlizzCon tickets this year (budget cuts),  only the first five Persons who were added to the queue will get them. This method should dequeue a Person from the queue, and if there are any tickets left, set that Person’s “hasTicket” field to true. Otherwise set “hasTicket” to false. Regardless of whether or not the Person got a ticket, add them to the completedList when you are finished.
            •	Report – This method should go through each Person in the completedList (if any) and report that person’s name, age, and whether or not they received a ticket to BlizzCon.

            To test your new class, instance a TicketVendor, add 10 Persons, and try to ticket all 10 of them. Then run a report and make sure the first five Persons who were added to the queue received tickets (and that nobody else did.)
            */
    }
}
