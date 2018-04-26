using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EmailSenderV01
{
    class BasicFunctions
    {

        // Function to Load from database into a list

        public void LoadMailing(string filepath, List<Contact> mailing)
        {
            List<Contact> Mailing = new List<Contact>();

            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Contact Person = new Contact();
                Person.Name = entries[0];
                Person.Url = entries[1];

                Mailing.Add(Person);
            }
        }







}
}
