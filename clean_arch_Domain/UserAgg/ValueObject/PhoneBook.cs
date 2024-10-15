using clean_arch_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_Domain.User.ValueObject
{
    public class PhoneBook : BaseValueObject
    {
        public PhoneNumber TelePhone { get; }
        public PhoneNumber Fax { get; }

        public PhoneBook(PhoneNumber telephone, PhoneNumber fax)
        {
            TelePhone = telephone;
            Fax = fax;
        }
    }
  
}
