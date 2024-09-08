using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch_Constracts
{
    public interface IsmsService 
    {
        void sendsms(smsbody  body);
    }
    public class smsbody
    {
        public string phoneNumber { get; set; }
        public string message { get; set; }
    }
}
