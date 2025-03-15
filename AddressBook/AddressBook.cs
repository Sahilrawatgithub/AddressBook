using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook: IAddressBook
    {
        List<Contact> contacts=new List<Contact>();

        public void Add()
        {
            Console.Write("Enter first name : ");
            string FirstName = Console.ReadLine();
            

            Console.Write("Enter last name : ");
            string Lastname = Console.ReadLine();

            if (contacts.Any(contact =>
              contact.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase) &&
              contact.LastName.Equals(Lastname, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Contact with the name '{FirstName} {Lastname}' already exists. Try another name.");
                return;
            }

            Console.Write("Enter address : ");
            string Address = Console.ReadLine();

            Console.Write("Enter city : ");
            string City = Console.ReadLine();

            Console.Write("Enter state : ");
            string State = Console.ReadLine();

            Console.Write("Enter zip code: ");
            string ZipCode = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string PhoneNumber = Console.ReadLine();
            if (!CheckPhone(PhoneNumber))
            {
                Console.WriteLine($"Invalid phone number {PhoneNumber}, please try again ");
                return;
            }

            Console.Write("Enter email: ");
            string Email = Console.ReadLine();
            if (!CheckEmail(Email))
            {
                Console.WriteLine($"Invalid email {Email}, please try again ");
                return;
            }
            Console.WriteLine();

            Contact c=new Contact(FirstName, Lastname, Address, City, State, ZipCode, PhoneNumber, Email);
            //if (contacts.Contains(c))
            //{
            //    Console.WriteLine($"Contact {FirstName} {Lastname} already exists.");
            //    return;
            //}
            contacts.Add(c);

            Console.WriteLine("New contact added");
            Console.WriteLine();
        }

        public bool CheckEmail(string email)
        {
            string emailSkeleton = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,10}$";
            Regex regEmail = new Regex(emailSkeleton);

            return regEmail.IsMatch(email);
        }

        public bool CheckPhone(string phonenumber)
        {
            string phoneSkeleton = @"^(\+91[\s]?91[\s]?)?[6-9][0-9]{9}$";
            Regex regPhone = new Regex(phoneSkeleton);
            return regPhone.IsMatch(phonenumber);
        }

        public void Display()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
              
            }
        }

        public void EditContact(string contactame)
        {
            Console.WriteLine();
            bool found = false;
            foreach (var contact in contacts)
            {
                if(contact.FirstName == contactame)
                {
                    found = true;
                    Console.WriteLine("Follow the following instruction to add details accordingly");
                    Console.WriteLine("Press 1 if you want to edit first name");
                    Console.WriteLine("Press 2 if you want to edit last name");
                    Console.WriteLine("Press 3 if you want to edit address");
                    Console.WriteLine("Press 4 if you want to edit city");
                    Console.WriteLine("Press 5 if you want to edit state");
                    Console.WriteLine("Press 6 if you want to edit zip code");
                    Console.WriteLine("Press 7 if you want to edit phone number");
                    Console.WriteLine("Press 8 if you want to edit email");
                    Console.WriteLine("Press 9 if you want to stop editing");

                    while (true)
                    {

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Enter first name : ");
                                string Firstname = Console.ReadLine();
                                contact.FirstName = Firstname;
                                Console.WriteLine("Edited first name");
                                break;

                            case "2":
                                Console.Write("Enter last name : ");
                                string Lastname = Console.ReadLine();
                                contact.LastName = Lastname;
                                Console.WriteLine("Edited Last name");                               
                                break;

                            case "3":
                                Console.Write("Enter address : ");
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Console.WriteLine("Edited address");
                                
                                break;

                            case "4":
                                Console.Write("Enter city : ");
                                string city = Console.ReadLine();
                                contact.City = city;
                                Console.WriteLine("Edited city");
                                break;

                            case "5":
                                Console.Write("Enter state : ");
                                string state = Console.ReadLine();
                                contact.State = state;
                                Console.WriteLine("Edited zipcode");
                               
                                
                                break;

                            case "6":
                                Console.Write("Enter zip code: ");
                                string zipCode = Console.ReadLine();
                                contact.Zip = zipCode;
                                Console.WriteLine("Edited zipcode");
                                break;

                            case "7":
                                Console.Write("Enter phone number: ");
                                string phoneNumber = Console.ReadLine();
                                if (!CheckPhone(phoneNumber))
                                {
                                    Console.WriteLine("Invalid phone number, cannot edit");                                 
                                    break;
                                }
                                contact.PhoneNumber = phoneNumber;
                                Console.WriteLine("Edited phone number");                              
                                break;

                            case "8":
                                Console.Write("Enter email: ");
                                string email = Console.ReadLine();
                                if (!CheckEmail(email))
                                {
                                    Console.WriteLine("Invalid email, cannot edit");                                   
                                    break;
                                }
                                contact.Email = email;
                                Console.WriteLine("Edited email");
                                
                                break;

                            case "9":
                                Console.WriteLine("Stopping editing the contact");
                                return;
                                
                            default:
                                Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");                              
                                break;

                        }
                        Console.WriteLine("What do you want to do next?");
                        Console.WriteLine();

                    }
                    
                }
               
            }
            if (!found)
            {
                Console.WriteLine("No such contact found.");
            }
        }
        public void DeleteContact(string contactname)
        {
            foreach (var contact in contacts)
            {
                if (contact.FirstName == contactname)
                {
                    contacts.Remove(contact);
                    Console.WriteLine($"{contactname} removed from AddressBook");
                    return;
                }              
            }
            Console.WriteLine("No such contact found");
        }

        
    }
}
