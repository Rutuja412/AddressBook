using System;

namespace UC4
{
    class Program

    {
        // public static List<Contacts> Person = new List<Contacts>();

        public static void Main(string[] args)
        {
            //Console.WriteLine("welcome Address book");
              UC4.Person.CreateContacts();

            Person.editContact();
            //UC4.Person.DisplayContact();
            UC4.Person.DeleteContact();



        }
    }


}
