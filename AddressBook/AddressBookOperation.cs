using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookOperation
    {
        public static List<Person> people = new List<Person>();
        public static void Add_Contact()
        {
            Console.WriteLine("Enter the first Name of person:");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter the last Name of person:");
            String lname = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            String email = Console.ReadLine();
            Console.WriteLine("Enter the city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            String zip = Console.ReadLine();
            Person detail = new Person(fname, lname, city, state, zip, email);
            people.Add(detail);


        }
    }
}
