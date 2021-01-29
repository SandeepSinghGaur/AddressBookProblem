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
        public void SetFname(string fname)
        {
            this.first_name = fname;
        }
        public void SetLname(string lname)
        {
            this.last_name = lname;
        }
        public void CityName(string lname)
        {
            this.city = city;
        }
        public void StateName(string lname)
        {
            this.state = state;
        }
        public void ZipNumber(string zip)
        {
            this.zip_number = zip;
        }
        public void EmailId(string email)
        {
            this.email_id = email;
        }
    }
}
