using System;
using System.Collections.Generic;

namespace ContactDirectory
{
    class Contact
    {
        public string Name { get; }
        public string Phone { get; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }

    class ContactBook
    {
        private readonly List<Contact> contacts = new List<Contact>();

        public void Add(string name, string phone)
        {
            contacts.Add(new Contact(name, phone));
        }

        public void Print()
        {
            Console.WriteLine("Contact List");
            Console.WriteLine("------------");

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Name} : {contact.Phone}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContactBook book = new ContactBook();

            book.Add("Alice", "555-1024");
            book.Add("Brian", "555-2048");
            book.Add("Clara", "555-4096");
            book.Add("David", "555-8192");

            book.Print();
        }
    }
}
