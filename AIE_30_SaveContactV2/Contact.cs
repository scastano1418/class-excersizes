﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace AIE_30_SaveContactV2
{
    class Contact
    {
        public string name = "";
        public string email = "";
        public string phone = "";

        public Contact()
        {

        }

        public Contact(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public void Serialise(string filename)
        {
            
            var fileInfo = new FileInfo(filename);
            var dir = fileInfo.Directory.FullName;
            Directory.CreateDirectory(dir);
        

       
        
            // TODO: use StreamReader to write the name, email and phone to file
            using (StreamWriter sw = File.CreateText(filename))
            {
                if (!string.IsNullOrWhiteSpace(name)) sw.WriteLine("name " + name);
                if (!string.IsNullOrWhiteSpace(email)) sw.WriteLine("email " + email);
                if (!string.IsNullOrWhiteSpace(phone)) sw.WriteLine("phone " + phone);

            }
        }
        public void DeSerialise(string filename) 
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var kvp = line.Split(" ");
                    if (kvp[0] == "name") name = kvp[1];
                    if (kvp[0] == "email") email = kvp[1];
                    if (kvp[0] == "phone") phone = kvp[1];
                    //kvp = (key value pair) and number in [] is the location in line.
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    } 
}
