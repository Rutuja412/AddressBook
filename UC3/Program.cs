using System;

namespace UC3
{
    class Program
    {
        // public static List<Contacts> Person = new List<Contacts>();

        public static void Main(string[] args)
        {
            //Console.WriteLine("welcome Address book");
            UC3.Person.CreateContacts();

            Person.editContact();
        }
    }
}
