using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Address
    {
        private String lname, city, state, phone, zip, email;
        //Parameterised constructor
        public Address(String fname, String lname,  String city, String state, String phone, String zip, string email)
        {
            //Instace Variables
            this.FirstName = fname;
            this.LastName = lname;
            this.City = city;
            this.State = state;
            this.PhoneNo = phone;
            this.ZipCode = zip;
            this.email = email;
        }
        // get method returns the value of the variables.
        // set method assigns a value to the variables.
        public string FirstName { get; set; }
        public string LastName { get => lname; set => lname = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNo { get => phone; set => phone = value; }
        public string ZipCode { get => zip; set => zip = value; }
        public string Email { get => email; set => email = value; }
        //Tostring  method storing value
        public override string ToString()
        {
            return "FirstName:- " + FirstName + "\nLastName:- " + LastName +  " \nCity:- " + City
                 + "\nState:- " + State + "\nZipCode:- " + ZipCode + "\nPhoneNo:- " + PhoneNo + "\nEmail:- " + email + " " + "\n";
        }
    }
}