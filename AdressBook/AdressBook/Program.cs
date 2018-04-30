using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contact> AdressBook = new List<Contact>();

            DateTime Example = new DateTime(1980, 2, 22);

            AdressBook.Add(new Contact("Gustavo", "Encinas", "55-2423757", Example, 38));
            AdressBook.Add(new Contact("Kenion", "Professor", "55-2423757", Example, 38));

            Console.WriteLine("Welcome to AddressBook APP");
            Console.WriteLine("What would you like to do? Type the number of the option.");

            Console.WriteLine("1) List all contacts in the AddressBook");
            Console.WriteLine("2) Add a new contact to the AddressBook");
            Console.WriteLine("3) Delete a contact");
            Console.WriteLine("4) Edit a contact");
            Console.WriteLine("5) Exit the APP");
           
            int Option = int.Parse(Console.ReadLine());
            
            switch (Option)
            {
                case 1:
                    {
                    Console.WriteLine("You chose option 1");
                        foreach ( var contact in AdressBook)
                        {
                            Console.WriteLine("Name: {0} Surname: {1} Tel: {2} DOB: {3} Age {4}",contact.FirstName, contact.SecondName, contact.PhoneNumber,contact.BirthDay, contact.Age);
                        }
                    Console.ReadLine();
                    break;
                    }

                case 2:
                    {
                        Console.WriteLine("You chose option 2");

                        Console.WriteLine("Type First Name:");
                        string firstn = Console.ReadLine();

                        Console.WriteLine("Type Second Name:");
                        string secondn = Console.ReadLine();

                        Console.WriteLine("Type Cell Phone (Format: 55.1234567:");
                        string phone = Console.ReadLine();

                        Console.WriteLine("Type Date of Birth (Format dd.mm.yyyy:");
                        DateTime dob = DateTime.Parse(Console.ReadLine());

                        DateTime now = DateTime.Today;
                        int age = now.Year - dob.Year;
                        Console.WriteLine("Age Computed as {0}", age);
                        Console.ReadLine();

                        AdressBook.Add(new Contact(firstn, secondn, phone, dob, age));
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("You chose option 3");
                        Console.WriteLine("Type first name of contact you want to delete:");
                        string subject = Console.ReadLine();

                        foreach (var contact in AdressBook)
                        {
                            if (contact.FirstName == subject)
                            {
                                AdressBook.Remove(contact);
                            }
                            
                        }
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("You chose option 2");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("You chose option 2");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Please choose between 1 and 5 as a valid option");
                        break;
                    }

            }





        }
    }
}
