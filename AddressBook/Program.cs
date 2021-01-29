using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System !");
            //AddressBookOperation.Add_Contact();
            //AddressBookOperation.Edit_Contact();
            //AddressBookOperation.Delete_Contact();
            int checkOut = 0;
            AddressBookOperation object1= new AddressBookOperation();
            do
            {
                Console.WriteLine("Enter Your choice 1: Add Person Details ");
                Console.WriteLine("Enter Your choice 2: Editing Person Details ");
                Console.WriteLine("Enter Your choice 3: Delete  Person Details ");
                Console.WriteLine("Enter Your choice 4: To exist ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddressBookOperation.Add_Contact();
                        AddressBookOperation.DisplayAddressBook();
                        break;
                    case 2:
                        AddressBookOperation.Edit_Contact();
                        AddressBookOperation.DisplayAddressBook();
                        break;
                    case 3:
                        object1.DeletPerson();
                        AddressBookOperation.DisplayAddressBook();
                        break;
                    default:
                        checkOut = 1;
                        break;
                }
            } while (checkOut == 0);
            AddressBookOperation.DisplayAddressBook();

        }
    }
}
        
    

