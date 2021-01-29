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
        public static void Edit_Contact()
        {
            Console.WriteLine("Enter the any valid name:");
            string inp_name = Console.ReadLine();
            foreach (var input_name in people)
            {
                bool result = inp_name.Equals(input_name);
                if (result == true)
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
                    detail.SetFname(fname);
                    detail.SetLname(lname);
                    detail.CityName(city);
                    detail.StateName(state);
                    detail.ZipNumber(zip);
                }
            }
        }
        public static void Delete_Contact()
        {
            Console.WriteLine("Enter the any valid name:");
            string inp_name = Console.ReadLine();
            foreach (var input in people)
            {
                if (inp_name.Equals(input))
                {
                    people.Remove(input);
                    Console.WriteLine("Deleted" + input + " " + "detail");
                }
            }

        }
        public Person DetectPerson()
        {
            Console.WriteLine("enter name of person ");
            String name = Console.ReadLine();
            foreach (Person person in people)
            {
                if (person.Equals(name))
                {
                    return person;
                }
            }
            return null;
        }

        public  void DeletPerson()
        {
            Person personDelet = DetectPerson();
            people.Remove(personDelet);
        }


        public static void DisplayAddressBook()
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.GetName());
                Console.WriteLine(person.GetPhoneNumber());
                Console.WriteLine(person.GetState());
                Console.WriteLine(person.GetCity());
                Console.WriteLine(person.Getzip());
                Console.WriteLine(person.GetEmailAddress());
            }
        }
    }
}
