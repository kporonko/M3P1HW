using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class ContactList
    {
        private Dictionary<string, List<Contact>> _contactList;
        private bool _isInitialized = false;
        private List<string> _symbols = new List<string>();
        public ContactList(List<string> symbols)
        {
            _symbols = symbols;
            _contactList = new Dictionary<string, List<Contact>>();
        }

        public void Add(Contact contact)
        {
            if (!_isInitialized)
            {
                Fill(_symbols);
            }

            if (char.IsDigit(contact.FullName[0]))
            {
                _contactList["0-9"].Add(contact);
            }
            else if (!_symbols.Contains(contact.FullName[0].ToString()))
            {
                _contactList["#"].Add(contact);
            }
            else
            {
                _contactList[contact.FullName[0].ToString()].Add(contact);
            }
        }

        public void Delete(string name)
        {
            // Maybe can be optimized. Not the n^2, but n if we find key we need by first letter of name. (It seems it cant).
            foreach (var contactGroup in _contactList)
            {
                foreach (var contact in contactGroup.Value.ToList())
                {
                    if (contact.FullName == name)
                    {
                        contactGroup.Value.Remove(contact);
                    }
                }
            }
        }

        public void Modify(string oldName, int oldNumber, string newName, int newNumber)
        {
            foreach (var contactGroup in _contactList)
            {
                foreach (var contact in contactGroup.Value.ToList())
                {
                    if (contact.FullName == oldName && contact.PhoneNumber == oldNumber)
                    {
                        if (newName[0] == oldName[0])
                        {
                            Add(new Contact(newName, newNumber));
                        }
                        else
                        {
                            contactGroup.Value.Remove(contact);
                            Add(new Contact(newName, newNumber));
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Your contacts:\n");
            foreach (var contactGroup in _contactList)
            {
                if (contactGroup.Value.Count != 0)
                {
                    sb.Append($"{contactGroup.Key}\n");
                }

                foreach (var contact in contactGroup.Value)
                {
                    sb.Append($"Name: {contact.FullName} Phone number: {contact.PhoneNumber}\n");
                }
            }

            return sb.ToString();
        }

        private void Fill(List<string> symbols)
        {
            for (int i = 0; i < symbols.Count; i++)
            {
                _contactList.Add(symbols[i].ToString(), new List<Contact>());
            }

            _isInitialized = true;
        }
    }
}
