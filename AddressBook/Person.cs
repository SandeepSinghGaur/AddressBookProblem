using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Person
    {
        public string first_name;
        public string last_name;
        public string city;
        public string state;
        public string zip_number;
        public string email_id;
        public Person(string fname, string lname, string city, string state, string zip, string email)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.city = city;
            this.state = state;
            this.zip_number = zip;
            this.email_id = email;
        }
    }
}
