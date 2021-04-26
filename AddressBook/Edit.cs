﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Edit
    {
        Address person = null;

        List<Address> list = new List<Address>(); //create a list of Person objects

        String fname = null; //empty string
        String lname, city, state, phone, zip, email; //Declaring (Creating) Variables

        public void AddRecord() //Addidng Record method
        {
            int i = 0;
            while (i == 0) // Checking name exixt or not
            {
                Console.Write("Enter First Name:- "); //take input user First name
                this.fname = Console.ReadLine();   //Store input fname            
                if (CheckExit(fname))  //Checking for duplicates firstname or user input are same or not
                {
                    Console.WriteLine($"Record with name { fname } Already Exist\n Please Enter New name:-");//print name Already Exist
                }
                else
                {
                    i = 1;
                }
            }
            Console.Write("Enter Last Name:- "); //Take input user
            lname = Console.ReadLine();            //Store input for lname
            Console.Write("Enter City:- "); //Take input user
            city = Console.ReadLine();        //Store input for city
            Console.Write("Enter State:- "); //Take input user
            state = Console.ReadLine();        //Store input for state
            Console.Write("Enter Zip:- "); //Take input user
            zip = Console.ReadLine();         //Store input for zip
            Console.Write("Enter Phone Number:-"); //Take input user
            phone = Console.ReadLine();           //Store input for phone
            Console.Write("Enter Email:- ");  //Take input user
            email = Console.ReadLine();           //Store input for email
            person = new Address(fname, lname, city, state, phone, zip, email);
            list.Add(person);   //adding list data person
        }
        public void DisplayRecord()  //Display Record Method
        {
            if (list.Count == 0) //Check list ==0
            {
                Console.WriteLine(" No Records Found"); //print record not found
            }
            else
            {
                foreach (Address k in list)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public void EditRecord(String fname) // EditRecord Method 
        {
            for (int k = 0; k < list.Count; k++) //Value  present or not
            {
                if (list[k].FirstName.Equals(fname))
                {
                    Address person = list[k];
                    Console.WriteLine(person);  //Print person
                    while (k == 0)  // k==0 to edite contact
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. city\n"
                                + "2. State\n"
                                + "3. Zip Code\n"
                                + "4. Phone\n"
                                + "5. Email\n"
                                + "6. Save And Exit\n");

                        int choice = Convert.ToInt32(Console.ReadLine());  //convert string and store choice
                        switch (choice)  //case 
                        {
                            case 1:
                                Console.Write("Enter new City:- "); //Take input user
                                String city = Console.ReadLine();  //store city veriable
                                person.City = city;                 //store class of person city data
                                break;
                            case 2:
                                Console.Write("Enter new State:- "); //Take input user
                                String state = Console.ReadLine();   //store state veriable
                                person.State = state;               //store class of person state data
                                break;
                            case 3:
                                Console.Write("Enter new Phone:- "); //Take input user
                                String phone = Console.ReadLine();   //store phone veriable
                                person.PhoneNo = phone;                 //store class of person phone data
                                break;
                            case 4:
                                Console.Write("Enter new Zip Code:- "); //Take input user
                                String zip = Console.ReadLine();        //store zip veriable
                                person.ZipCode = zip;                       //store class of person zip data
                                break;
                            case 5:
                                Console.Write("Enter new Email:- "); //Take input user
                                String email = Console.ReadLine();         //store email veriable
                                person.Email = email;                       //store class of person Email data
                                break;
                            case 6:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        foreach (Address t in list) //automate the reading  t of person of class
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                } //end of edit() method
            }
        }

    }
}
