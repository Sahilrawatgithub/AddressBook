﻿namespace AddressBook
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            
            Dictionary<string, IAddressBook> Addressbook = new Dictionary<string, IAddressBook>();

            Console.WriteLine("Welcome to AddressBookSystem, please adhere to following instructions to have a smooth experience");
            Console.WriteLine("Press 1 if you want to add a new addressbook to the system");
            Console.WriteLine("Press 2 if you want to add a contact in a particular addressbook");
            Console.WriteLine("Press 3 if you want to Display all adressbooks in the system");
            Console.WriteLine("Press 4 if you want to Display all addressbooks with their contents");
            Console.WriteLine("Press 5 if you want to exit program");
            Console.WriteLine();

            while (true)
            {
                switch (Console.ReadLine())
                {
                   
                    case "1":
                        Console.WriteLine("Enter the name of the new addressbook");
                        string name=Console.ReadLine();

                        if(Addressbook.ContainsKey(name)) {
                                Console.WriteLine("AddressBook with a same name already exists in the system. Please try again");
                            break;
                            }
                        Addressbook.Add(name, new AddressBook());
                       
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of the addressbook where you want to add the contact : ");
                        string BookName=Console.ReadLine();
                        Addressbook[BookName].Add();
                        break;

                    case "3":

                        foreach (var book in Addressbook.Keys)
                        {
                            Console.WriteLine(book);
                        }
                    break;

                    case "4":

                        foreach(var book in Addressbook)
                        {
                            Console.WriteLine(book.Key);
                            book.Value.Display();
                            Console.WriteLine();
                        }

                        break;


                    case "5":
                        Console.WriteLine("Exiting the system....");
                        return;

                    default:
                        Console.WriteLine("Invalid input, please follow insturctions properly");
                        break;
                }
                Console.WriteLine("What do you want to do next");
                Console.WriteLine();
            }      

        }
    }
}
