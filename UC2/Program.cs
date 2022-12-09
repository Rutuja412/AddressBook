using System;
using System.Collections.Generic;

namespace UC2
{
    public class Program
    {
        public static List<Contacts> Person = new List<Contacts>();

        public static void Main(string[] args)
        {
            Console.WriteLine("welcome Address book");
            UC2.Person.CreateContacts();

            
        }
    }
}
