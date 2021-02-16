using System;
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


        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    } 
}
