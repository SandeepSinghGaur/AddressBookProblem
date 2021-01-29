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
        public string phoneNumber;
        public Person(string fname, string lname, string city, string state, string zip, string email)
        {
            this.first_name = fname;
            this.last_name = lname;
            this.city = city;
            this.state = state;
            this.zip_number = zip;
            this.email_id = email;
        }
        public string GetName()
        {
            return this.first_name;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string GetState()
        {
            return this.state;
        }
        public string GetCity()
        {
            return this.city;
        }
        public string Getzip()
        {
            return this.zip_number;
        }
        public string GetEmailAddress()
        {
            return this.email_id;
        }
        public void SetFname(string fname)
        {
            this.first_name = fname;
        }
        public void SetLname(string lname)
        {
            this.last_name = lname;
        }
        public void CityName(string city)
        {
            this.city = city;
        }
        public void StateName(string state)
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
