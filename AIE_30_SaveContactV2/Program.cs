﻿using System;

namespace AIE_30_SaveContactV2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Contact person1 = new Contact("bob", "bob@email.com", "12345678");
                Contact person2 = new Contact("fred", "fred@email.com", "12345678");
                Contact person3 = new Contact("ted", "ted@email.com", "12345678");

                // write each contact to file
                person1.Serialise("./contacts/bob.txt");
                person2.Serialise("./contacts/fred.txt");
                person3.Serialise("./contacts/ted.txt");


                // lets clear out the "contact" and load it back in from file
                person1 = new Contact();
                person2 = new Contact();
                person3 = new Contact();

                //person1.Deserialise("./contacts/bob.txt");
                //person2.Deserialise("./contacts/fred.txt");
                //person3.Deserialise("./contacts/ted.txt");

                person1.Print();
                person2.Print();
                person3.Print();
            }
        }
    }

}