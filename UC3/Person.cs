using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    public class Person
    {
        public static List<Contacts> person = new List<Contacts>();
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter EmailID ");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode ");
            contacts.zipcode = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            contacts.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Created new contact \n");


            //Person.Add(contacts);
            Console.WriteLine("Contact added to your Address book");
        }

        public void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName :" + data.FirstName);
            }
        }
        public static void editContact()
        {
            Console.WriteLine("Enter First Name :");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string FirstName = Console.ReadLine();
                                data.FirstName = FirstName;
                                break;
                            case 2:
                                string LastName = Console.ReadLine();
                                data.LastName = LastName;
                                break;

                        }



                    }
                    else
                    {
                        Console.WriteLine("Name does not match");
                    }
                }
            }
        }
    }
}