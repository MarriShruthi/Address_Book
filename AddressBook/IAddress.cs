using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    interface IAddress
    {
        void addPerson();
        void displayPerson();
        void editPerson();
        void deletePerson();
    }
}
