using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Contact> contacts=new List<Contact>();

        public void Add(Contact contact)
        {
            String emailSkeleton = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,10}$";
            String phoneSkeleton = @"^(\+91[\s]?|91[\s]?)?[6-9][0-9]{9}$";

            Regex regEmail = new Regex(emailSkeleton);
            Regex regPhone = new Regex(phoneSkeleton);

            if (! regEmail.IsMatch(contact.Email) || !regPhone.IsMatch(contact.PhoneNumber)){
                Console.WriteLine("Invalid Email or Phone Number, could not add contact, please try again!");
                return;
            }

            contacts.Add(contact);
            Console.WriteLine("New contact added");
        }
    }
}
