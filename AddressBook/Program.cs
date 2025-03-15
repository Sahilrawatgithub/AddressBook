namespace AddressBook
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
            Console.WriteLine("Press 5 if you want to search for a person in a city or state across all Addressbooks");
            Console.WriteLine("Press 6 if you want to exit program");
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
                        if (!Addressbook.ContainsKey(BookName))
                        {
                            Console.WriteLine("No such AddressBook exists. PLease try again");
                            Console.WriteLine();
                            break;
                        }
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
                        Console.Write("Enter First name : ");
                        string Sname= Console.ReadLine();

                        Console.Write("Enter Last name : ");
                        string SLname = Console.ReadLine();

                        Console.Write("Enter city : ");
                        string city=Console.ReadLine();

                        Console.Write("Enter state : ");
                        string state=Console.ReadLine();
                        
                        bool found = false;

                        foreach(var entry in Addressbook)
                        {
                            string book=entry.Key;
                            var contacts=entry.Value.GetContacts();

                            foreach(var contact in contacts)
                            {
                                bool FirstNameMatch=contact.FirstName.Equals(Sname,StringComparison.OrdinalIgnoreCase);
                                bool LastNameMatch = contact.LastName.Equals(SLname, StringComparison.OrdinalIgnoreCase);
                                bool CityMatch = contact.City.Equals(city, StringComparison.OrdinalIgnoreCase);
                                bool StateMatch=contact.State.Equals(state, StringComparison.OrdinalIgnoreCase);

                                if(FirstNameMatch && LastNameMatch && CityMatch)
                                {
                                    found = true;
                                    Console.WriteLine($"{Sname} {SLname} found in {city} in addressbook {book}");
                                    Console.WriteLine();
                                    break;
                                }
                                else if (FirstNameMatch && LastNameMatch && StateMatch)
                                {
                                    found = true;
                                    Console.WriteLine($"{Sname} {SLname} found in {state} in addressbook {book}");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("No such contact found.");
                            Console.WriteLine();
                        }
                        break;
                        


                    case "6":
                        Console.WriteLine("Exiting the system....");
                        return;

                    default:
                        Console.WriteLine("Invalid input, please follow instructions properly");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("What do you want to do next?");
                Console.WriteLine();
            }      

        }
    }
}
