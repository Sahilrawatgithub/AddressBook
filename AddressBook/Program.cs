namespace AddressBook
{
    internal class Program
    {

        static Dictionary<string, IAddressBook> Addressbook = new Dictionary<string, IAddressBook>();

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to AddressBookSystem, please adhere to following instructions to have a smooth experience");
            Console.WriteLine("Press 0 if you want to exit...");
            Console.WriteLine("Press 1 if you want to add a new addressbook to the system");
            Console.WriteLine("Press 2 if you want to add a contact in a particular addressbook");
            Console.WriteLine("Press 3 if you want to Display all adressbooks in the system");
            Console.WriteLine("Press 4 if you want to Display all addressbooks with their contents");
            Console.WriteLine("Press 5 if you want to search for a person in a city or state across all Addressbooks");
            Console.WriteLine("Press 6 if you want to view contacts by location.");
            Console.WriteLine("Press 7 if you want to get count of people by City and State");
            Console.WriteLine("Press 8 if you want to sort entries in an addressbook by Person's name");
            Console.WriteLine("Press 9 if you want to sort entries by city");
            Console.WriteLine("Press 10 if you want to sort entries by state");
            Console.WriteLine("Press 11 if you want to sort entries by zip");
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
                        Console.Write("Enter city or state : ");
                        string location=Console.ReadLine();

                        if (Addressbook.Count == 0)
                        {
                            Console.WriteLine("The addressbook system is empty");
                            break;
                        }

                        bool exists = false;

                        foreach(var entry in Addressbook)
                        {
                            var contacts=entry.Value.GetContacts();

                            foreach(Contact contact in contacts)
                            {
                                if(contact.City.Equals(location,StringComparison.OrdinalIgnoreCase) || contact.State.Equals(location, StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine(contact);
                                    Console.WriteLine();
                                    exists = true;
                                }
                            }
                        }
                        if (!exists) Console.WriteLine("No contact exists in given location");

                        break;

                    case "7":
                        Dictionary <string, int> CountByCity = new Dictionary<string, int>();
                        foreach (var entry in Addressbook)
                        {
                            foreach(var contact in entry.Value.GetContacts())
                            {
                                if (!CountByCity.ContainsKey(contact.City))
                                {
                                    CountByCity[contact.City] = 1;
                                }
                                else
                                {
                                    CountByCity[contact.City]++;
                                }
                            }
                        }

                        foreach(var entry in CountByCity)
                        {
                            Console.WriteLine($"People in City {entry.Key} : {entry.Value}");
                        }
                        Console.WriteLine();

                        Dictionary<string, int> CountByState = new Dictionary<string, int>();
                        foreach (var entry in Addressbook)
                        {
                            foreach (var contact in entry.Value.GetContacts())
                            {
                                if (!CountByState.ContainsKey(contact.State))
                                {
                                    CountByState[contact.State] = 1;
                                }
                                else
                                {
                                    CountByState[contact.State]++;
                                }
                            }
                        }
                        foreach (var entry in CountByState)
                        {
                            Console.WriteLine($"People in State {entry.Key} : {entry.Value}");
                        }
                        Console.WriteLine();


                        break;

                    case "8":

                        Console.Write("Enter the name of the addressbook you want to sort : ");
                        string sbook=Console.ReadLine();

                        if (!Addressbook.ContainsKey(sbook))
                        {
                            Console.WriteLine("No such addressbook exists in system..");
                            break;
                        }
                        if (Addressbook[sbook].count()==0)
                        {
                            Console.WriteLine($"No contacts in addressbook {sbook}");
                            break;
                        }

                        Addressbook[sbook].SortByName();
                        Console.WriteLine($"Contacts in addressbook '{sbook}' have been sorted by first name! \n Here are the contents of the addressbook after sorting \n");
                        Addressbook[sbook].Display();
                        Console.WriteLine();
                        break;

                    case "9":
                        Console.Write("Enter the name of the addressbook you want to sort : ");
                        string bname=Console.ReadLine();
                        if (!Addressbook.ContainsKey(bname))
                        {
                            Console.WriteLine("No such addressbook exists in the system, please try again");
                            break;
                        }
                        if (Addressbook[bname].count() == 0)
                        {
                            Console.WriteLine("No contacts in addressbook "+ bname);
                            break;
                        }

                        Addressbook[bname].SortByCity();
                        Console.WriteLine($"Contacts in addressbook '{bname}' have been sorted by zip!\nHere are the contents of the addressbook after sorting:\n");

                        Addressbook[bname].Display();
                        break;

                    case "10":
                        Console.Write("Enter the name of the addressbook you want to sort : ");
                        string bookByState = Console.ReadLine();

                        if (!Addressbook.ContainsKey(bookByState))
                        {
                            Console.WriteLine("No such addressbook exists in the system, please try again.");
                            break;
                        }

                        if (Addressbook[bookByState].count() == 0)
                        {
                            Console.WriteLine($"No contacts in addressbook {bookByState}");
                            break;
                        }

                        Addressbook[bookByState].SortByState();
                        Console.WriteLine($"Contacts in addressbook '{bookByState}' have been sorted by state!\nHere are the contents of the addressbook after sorting:\n");
                        Addressbook[bookByState].Display();
                        Console.WriteLine();
                        break;

                    case "11":
                        Console.Write("Enter the name of the addressbook you want to sort : ");
                        string bookByZip = Console.ReadLine();

                        if (!Addressbook.ContainsKey(bookByZip))
                        {
                            Console.WriteLine("No such addressbook exists in the system, please try again.");
                            break;
                        }

                        if (Addressbook[bookByZip].count() == 0)
                        {
                            Console.WriteLine($"No contacts in addressbook {bookByZip}");
                            break;
                        }

                        Addressbook[bookByZip].SortByZip();
                        Console.WriteLine($"Contacts in addressbook '{bookByZip}' have been sorted by zip!\nHere are the contents of the addressbook after sorting:\n");
                        Addressbook[bookByZip].Display();
                        Console.WriteLine();
                        break;

                    case "0":
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
