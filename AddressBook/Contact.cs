using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;
        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name       : {FirstName} {LastName}\n" +
                   $"Address    : {Address}\n" +
                   $"City       : {City}\n" +
                   $"State      : {State}\n" +
                   $"Zip Code   : {Zip}\n" +
                   $"Phone      : {PhoneNumber}\n" +
                   $"Email      : {Email}\n";
        }
    }
}
