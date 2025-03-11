namespace AddressBook
{
    internal class Program
    {
        static List<Contact> AddressBook = new List<Contact>();
        static void Main(string[] args)
        {
            Console.WriteLine("This is UC1 where you can add contact in Address Book");
  
            AddressBook.Add(new Contact("John", "Doe", "123 Main ", "Springfield", "NY", "62701", "217-555-1234", "john@gmai.com"));
            Console.WriteLine("Contact added");

        }
    }
}
