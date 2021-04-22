using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Welcome to Address Book ---");
            Address person = new Address("Shruthi", "Marri", "Hyderabad", "Hyderabad", "Telangana", "501505", "9123456789", "shruthimarri97@gmail.com");
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.Read();
        }
    }
}
