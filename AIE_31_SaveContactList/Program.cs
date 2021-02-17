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
         contacts.Add(new Contact("fred", "fred@email.com", ""));
         contacts.Add(new Contact("ted", "", "12345678"));

                // save to file
         SerialiseContactList("contacts.txt", contacts);

                // clear them out
         contacts = new List<Contact>();

                // read from file
         DeSerialiseContactList("contacts.txt", contacts);

        }    

       static void SerialiseContactList(string filename, List<Contact> contacts)
       {
            var fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);

            using ( StreamWriter sw = File.CreateText(filename))
            {
                foreach(var contact in contacts)
                {
                    if (!string.IsNullOrWhiteSpace(contact.name)) sw.WriteLine("name " + contact.name);
                    if (!string.IsNullOrWhiteSpace(contact.email)) sw.WriteLine("email " + contact.email);
                    if (!string.IsNullOrWhiteSpace(contact.phone)) sw.WriteLine("phone " + contact.phone);
                    sw.WriteLine("");
                }
            }
       }

       static void DeSerialiseContactList(string filename, List<Contact> contacts)
       {
         Contact contact = new Contact();

          using (StreamReader sr = File.OpenText(filename))
          {
            string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        contacts.Add(contact);
                        contact = new Contact();
                    }
                    else
                    {
                        var kvp = line.Split(" ");
                        if (kvp[0] == "name") contact.name = kvp[1];
                        if (kvp[0] == "email") contact.email = kvp[1];
                        if (kvp[0] == "phone") contact.phone = kvp[1];
                    }
                   
                }
          }
       }
        
    }
}
