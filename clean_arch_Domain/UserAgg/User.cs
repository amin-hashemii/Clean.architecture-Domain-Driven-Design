using clean_arch_Domain.Shared;
using clean_arch_Domain.User.ValueObject;
using clean_arch_Domain.UserAgg.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.User
{
    public class User :AggregateRoot
    {
        public User(string name, string family, PhoneBook phonebook, string email)
        {
            Name = name;
            Family = family;
            PhoneBook = phonebook;
            Email = email;
        }
        public string Name { get; private set; }
        public string Email {  get; private set; }
        public string Family {  get; private set; }
        public PhoneBook PhoneBook { get; private set; }
      
        public static User Rrgister( string email)
        {
            var user= new User("", "", null, email);
            user.AddDomainEvent(new UserRegistered(user.Id, email));
            return user;
           
        }

    }
}
