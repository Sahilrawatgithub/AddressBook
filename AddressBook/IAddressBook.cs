using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal interface IAddressBook
    {
        public void Add();
        public void DeleteContact(string contactname);
        public void EditContact(string contactname);

        public void Display();

        public bool CheckEmail(string email);

        public bool CheckPhone(string phone);
        public List<Contact> GetContacts();
    }
}
