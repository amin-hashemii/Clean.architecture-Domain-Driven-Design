using clean_arch_Domain.User.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.User
{
    public class User 
    {
        public User(string name, string family, PhoneBook phonebook)
        {
            Name = name;
            Family = family;
            PhoneBook= phonebook;

        }
        public string Name { get; private set; }
        public string Family {  get; private set; }
        public PhoneBook PhoneBook { get; private set; }
      

    }
}
