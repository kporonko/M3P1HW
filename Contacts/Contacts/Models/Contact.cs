using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Contact
    {
        public Contact(string fullName, int phoneNum)
        {
            FullName = fullName.First().ToString().ToUpper() + fullName.Substring(1);
            PhoneNumber = phoneNum;
        }

        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
