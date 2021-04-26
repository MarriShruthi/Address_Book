using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    interface IAddress
    {
        void AddContact(string firstName, string lastName, string city, string state, string email, int zip, long phoneNumber);
        void EditContact(string name);
        void DeleteContact(string name);
    }
}
