using System;
using System.Text;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******WelCome To Address Book******");
            Edit edit = new Edit();

            //Create Variables
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("\n1. Add New Person      ");
                Console.WriteLine("2. Display Records     ");
                Console.WriteLine("3. Edit Records        ");
                Console.WriteLine("4. Delete Records      ");
                Console.WriteLine("5. Exit		        \n");
                Console.Write("Enter Your Choice:- ");
                //Covert in String
                int choice = Convert.ToInt32(Console.ReadLine());
                //Add switch case for choice
                switch (choice)
                {
                    case 1:
                        //call AddRecord Method
                        edit.AddRecord();
                        break;
                    case 2:
                        //call DisplayRecord Method
                        edit.DisplayRecord();
                        break;
                    case 3:
                        Console.Write("Enter First Name To Edit Records:- ");
                        String firstName = Console.ReadLine();
                        //call Edit record method
                        edit.EditRecord(firstName);
                        break;
                    case 4:
                        Console.Write("Enter First Name To Delete Records:- ");
                        String Name = Console.ReadLine();
                        //call Delete record method
                        edit.DeletePersonRecord(Name);
                        break;
                    case 5:
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("Enter Valid Option");
                        break;
                }//End of switch
            }
        }
    }
}
