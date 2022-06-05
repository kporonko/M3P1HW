using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services
{
    /// <summary>
    /// Realization for culture of En Us.
    /// </summary>
    internal class StarterEnUs : IStarter
    {
        public StarterEnUs(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo;
        }

        public CultureInfo CultureInfo { get; set; }

        public void Start()
        {
            List<string> list = CultureInfo.GetAlphabet();
            ContactList contactList = new Contacts.ContactList(list);
            contactList.Add(new Contact("ababb", 12323));
            contactList.Add(new Contact("baba", 12323));
            contactList.Add(new Contact("caca", 12323));
            contactList.Add(new Contact("cboba", 12323));
            contactList.Add(new Contact("doctor", 12323));
            contactList.Add(new Contact("ethan", 12323));
            contactList.Add(new Contact("bobik", 12323));
            contactList.Add(new Contact("cac", 12323));
            contactList.Add(new Contact("ta", 12323));
            contactList.Add(new Contact("tat", 12323));
            contactList.Add(new Contact("tboba", 12323));
            contactList.Add(new Contact("taaaa", 12323));
            contactList.Add(new Contact("taaaaaaaaaa", 12323));
            contactList.Add(new Contact("tf", 12323));

            Console.WriteLine(contactList.ToString());
            contactList.Delete("Ta");
            contactList.Delete("Tat");
            contactList.Delete("Tboba");

            Console.WriteLine(contactList.ToString());

            contactList.Modify("Ababb", 12323, "BNEWABBA", 123111111);
            Console.WriteLine(contactList.ToString());
        }
    }
}
