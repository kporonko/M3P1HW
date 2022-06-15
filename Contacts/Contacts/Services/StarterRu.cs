using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services
{
    /// <summary>
    /// Realization for culture of Ru.
    /// </summary>
    internal class StarterRu : IStarter
    {
        public StarterRu(CultureInfo cultureInfo)
        {
            CultureInfo = cultureInfo;
        }

        public CultureInfo CultureInfo { get; set; }

        public void Start()
        {
            List<string> list = CultureInfo.GetAlphabet();
            ContactList contactList = new Contacts.ContactList(list);
            contactList.Add(new Contact("Анна", 12323));
            contactList.Add(new Contact("Богдан", 12323));
            contactList.Add(new Contact("Саша", 12323));
            contactList.Add(new Contact("Соня", 12323));
            contactList.Add(new Contact("доктор", 12323));
            contactList.Add(new Contact("итан", 12323));
            contactList.Add(new Contact("Бобик", 12323));
            contactList.Add(new Contact("Стас", 12323));
            contactList.Add(new Contact("та", 12323));
            contactList.Add(new Contact("тат", 12323));
            contactList.Add(new Contact("тбоба", 12323));
            contactList.Add(new Contact("тааа", 12323));
            contactList.Add(new Contact("таааааааа", 12323));
            contactList.Add(new Contact("тф", 12323));

            Console.WriteLine(contactList.ToString());
            contactList.Delete("Та");
            contactList.Delete("Тат");
            contactList.Delete("Тбоба");

            Console.WriteLine(contactList.ToString());

            contactList.Modify("Анна", 12323, "+Анна", 123111111);
            Console.WriteLine(contactList.ToString());
        }
    }
}
