using System;
using System.Collections.Generic;

namespace AddressBook
{
    class AddMultiPleBook
    {
        Dictionary<string, AddressBookOperation> addBookinDic = new Dictionary<string, AddressBookOperation>();

        public void OpenAddressBook()
        {
            Console.WriteLine("Address Book We Have Created");
            Console.WriteLine("Enter name of Address Book which we want open");
            string bookName = Console.ReadLine();
            Boolean keyPresent = addBookinDic.ContainsKey(bookName);
            if (keyPresent)
            {
                AddressBookOperation addressBook = addBookinDic[bookName];
                Console.WriteLine("Address Book:\n"
                + "1) Add Person\n"
                + "2) Edit Person\n"
                + "3) Display\n"
                + "4) Delete Person\n"
                + "5) Close");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookOperation.Add_Contact();
                        break;
                    case 2:
                        AddressBookOperation.Edit_Contact();
                        break;
                    case 3:
                        AddressBookOperation.DisplayAddressBook();
                        break;
                    case 4:
                        AddressBookOperation.Delete_Contact();
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Address Book is not present");
            }
        }
        public void NewAddressBook()
        {
            AddressBookOperation addressBook = new AddressBookOperation();
            Console.WriteLine("Enter name of address book");
            String bookName = Console.ReadLine();
            bool keyPresent = addBookinDic.ContainsKey(bookName);
            if (keyPresent)
                Console.WriteLine("Already Present");
            else
                addBookinDic.Add(bookName, addressBook);
        }
    }
}
