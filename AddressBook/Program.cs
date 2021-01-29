using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book System !");
            Console.WriteLine("Create Contact in Address Book");
            Console.WriteLine("Enter the Name of person:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            String phoneNumber = Console.ReadLine();
        }
    }
}
