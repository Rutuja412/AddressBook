﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC1
{
    public class Person
    {
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
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contacts.PhoneNumber =Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Created new contact \n");

        }

    }
}
