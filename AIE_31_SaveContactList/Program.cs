using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_31_SaveContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
         List<Contact> contacts = new List<Contact>();
         contacts.Add(new Contact("bob", "bob@email.com", "12345678"));
         contacts.Add(new Contact("fred", "fred@email.com", "12345678"));
         contacts.Add(new Contact("ted", "ted@email.com", "12345678"));

                // save to file
         SerialiseContactList("contacts.txt", contacts);

                // clear them out
         contacts = new List<Contact>();

                // read from file
         DeSerialiseContactList("contacts.txt", contacts);

            

            static void SerialiseContactList(string filename, List<Contact> contacts)
            {
                using (StreamReader sr = File.OpenText(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" ");
                        string key = parts[0];
                        string value = parts[1];

                        if (key == "name") name = value;
                        if (key == "email") email = value;
                        if (key == "phone") phone = value;
                    }
                }
            }

            static void DeSerialiseContactList(string filename, List<Contact> contacts)
            {
               
            }
        }
    }
}
