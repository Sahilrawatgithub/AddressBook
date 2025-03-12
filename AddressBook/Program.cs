namespace AddressBook
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("I have done what UC5 wants me to do in previous use cases already, so i will just push this without changes");
            Console.WriteLine("Welcome to AddressBookManager, please adhere to following instructions to have a smooth experience");
            Console.WriteLine("Press 1 if you want to add a contact to the addressbook");
            Console.WriteLine("Press 2 if you want to edit existing contact and");
            Console.WriteLine("Press 3 if you want to display contacts in addressbook");
            Console.WriteLine("Press 4 if you want to remove contact from addressbook");
            Console.WriteLine("Press 5 to exit program");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter first name : ");
                        string FirstName=Console.ReadLine();

                        Console.Write("Enter last name : ");
                        string Lastname = Console.ReadLine();

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

                        Console.Write("Enter email: ");
                        string Email = Console.ReadLine();
                        Console.WriteLine();
                        

                        addressBook.Add(new Contact(FirstName, Lastname, Address, City, State, ZipCode, PhoneNumber, Email));

                        break;
                   
                    case "2":
                        Console.Write("Enter First name of contact you want to edit : ");
                        string fname=Console.ReadLine();
                        addressBook.EditContact(fname);

                    break;
                        
                    case "3":
                        addressBook.Display();
                        break;
                    
                    case "4":
                        Console.Write("Enter firstname of contact you want to remove: ");
                        string firstname=Console.ReadLine();
                        addressBook.DeleteContact(firstname);
                        break;

                    case "5":
                        return;
                       
                }
                Console.WriteLine("What do you want to do next?");
                Console.WriteLine();
            }

        }
    }
}
