using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Edit 
    {
        //Create Variables
        Address person = null;
        //create a list of Person objects
        List<Address> list = new List<Address>();

        String fname = null; //empty string
        String lname, city, state, phone, zip, email; //Declaring (Creating) Variables

        public void AddRecord() //Addidng Record method
        {
            int i = 0;
            while (i == 0) // Checking name exixt or not
            {
                Console.Write("Enter First Name:- "); //take input user First name
                this.fname = Console.ReadLine();   //Store input fname            
                if (CheckForPersonExist(fname))  //Checking for duplicates firstname or user input are same or not
                {
                    Console.WriteLine($"Record with name { fname } Already Exist\n Please Enter New name:-");//print name Already Exist
                }
                else
                {
                    i = 1;
                }
            }//Taking Inputs from Users and Store inputes in onject
            Console.Write("Enter Last Name:- ");
            lname = Console.ReadLine();
            Console.Write("Enter City:- ");
            city = Console.ReadLine();
            Console.Write("Enter State:- ");
            state = Console.ReadLine();
            Console.Write("Enter Zip:- ");
            zip = Console.ReadLine();
            Console.Write("Enter Phone Number:-");
            phone = Console.ReadLine();
            Console.Write("Enter Email:- ");
            email = Console.ReadLine();
            person = new Address(fname, lname, city, state, phone, zip, email);
            list.Add(person);   //adding list data person
        }
        //Added Display Record Method

        public void DisplayRecord()
        {
            if (list.Count == 0) //Check list ==0
            {
                //print record not found
                Console.WriteLine(" No Records Found");
            }
            else
            {
                //For loop For person Details 
                foreach (Address k in list)
                {
                    Console.WriteLine(k);
                }
            }
        }
        // Added EditRecord Method 
        public void EditRecord(String fname)
        {
            //For loop for Value  present or not
            for (int k = 0; k < list.Count; k++)
            {
                if (list[k].FirstName.Equals(fname))
                {
                    //Calling List
                    Address person = list[k];
                    //Print person
                    Console.WriteLine(person);
                    // k==0 to editRecord contact
                    while (k == 0)
                    {
                        Console.WriteLine("What Do You Want to edit Contact Details \n"
                                + "1. city"
                                + "2. State"
                                + "3. Zip Code"
                                + "4. Phone"
                                + "5. Email"
                                + "6. Save And Exit");
                        //convert string and store choice
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)  //case 
                        {
                            case 1:
                                //Take input user
                                Console.Write("Enter new City:- ");
                                //storing city variable
                                String city = Console.ReadLine();
                                //store class of person city data
                                person.City = city;
                                break;
                            case 2:
                                //Take input user
                                Console.Write("Enter new State:- ");
                                //store state variable
                                String state = Console.ReadLine();
                                //store class of person state data
                                person.State = state;
                                break;
                            case 3:
                                //Take input user
                                Console.Write("Enter new Phone:- ");
                                //storing city variable
                                String phone = Console.ReadLine();
                                //store class of person phone data
                                person.PhoneNo = phone;
                                break;
                            case 4:
                                //Take input user
                                Console.Write("Enter new Zip Code:- ");
                                //store zip variable
                                String zip = Console.ReadLine();
                                //store class of person zip data
                                person.ZipCode = zip;
                                break;
                            case 5:
                                //Take input user
                                Console.Write("Enter new Email:- ");
                                //store email variable
                                String email = Console.ReadLine();
                                //store class of person Email data
                                person.Email = email;
                                break;
                            case 6:
                                k = 1;
                                break;
                            default:
                                Console.WriteLine("Please Enter Valid Option");
                                break;
                        }
                        //For person Details
                        foreach (Address t in list)
                        {
                            Console.WriteLine(t);//print list
                        }
                    }
                } //end of edit() method
            }
        }
        // Added Delete Record Method
        public void DeletePersonRecord(string firstName)
        {
            //Cheack record present or not in list
            for (int i = 0; i < list.Count; i++)
            {
                //Cheack list of record and user inpute same or not
                if (list[i].FirstName.Equals(firstName))
                {
                    //For Removing Record from Person class
                    list.Remove(this.person); //Call person name
                    //Print Record Delete
                    Console.WriteLine("Name of Record Delete Successfully" + firstName);
                }
                else
                {
                    //Print Record not found
                    Console.WriteLine("Name of Record Not Found " + firstName);
                }
            }
        }
        //Adding Check exist method
        public bool CheckForPersonExist(string fname)
        {
            int flag = 0;
            //Check list of class person
            foreach (Address person in list)
            {
                //check first name and user input are equal or not if equal print
                if (person.FirstName.Equals(fname))
                {
                    flag = 1;
                    break;
                }
            }//End of foreach
            if (flag == 1)
            {
                return true;
            }//End of Sencond if
            return false;
        }
    }
}
