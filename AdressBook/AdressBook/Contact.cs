using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age { get; set; }

        public Contact(string firstname, string secondname, string phonenumber, DateTime birthday, int age)
        {
            FirstName = firstname;
            SecondName = secondname;
            PhoneNumber = phonenumber;
            BirthDay = birthday;
            Age = age;
        }
    }
}
