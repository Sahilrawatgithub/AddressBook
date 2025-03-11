📒 Address Book System
Welcome to the Address Book System project! This program demonstrates Object-Oriented Programming concepts in C#, with advanced features like File I/O, Database interactions, Cloud Server integration, and Multi-Threading.

🌟 Outcome
By the end of this project, you will:

Work with File Handles (File I/O)
Perform operations using Databases
Save data to a Cloud Server
Use Multi-Threading for I/O or network calls
🚀 Getting Started
IDE: Visual Studio
Language: C#
Version Control: Git
Branch Strategy: Every Use Case (UC) is implemented in a separate Git branch and merged into the main branch.
Code Hygiene: Naming Conventions, Indentation, and Clean Code practices are followed.
Review Guidelines: Git check-in comments and version history are monitored.
🎯 Features & Use Cases (UC)
UC 0
✅ Start Point

Display Welcome to Address Book Program in the AddressBookMain class
Branch: UC0_WelcomeMessage
UC 1
✅ Add a New Contact

Add a contact with: First Name, Last Name, Address, City, State, Zip, Phone Number, and Email.
Use console input to gather details.
Object-Oriented Concepts manage AddressBook and ContactPerson.
Branch: UC1_AddContact
UC 2
✅ Edit an Existing Contact by Name

Edit person details using the console input.
Branch: UC2_EditContact
UC 3
✅ Delete a Contact by Name

Remove contact person from the Address Book.
Branch: UC3_DeleteContact
UC 4
✅ Add Multiple Persons to Address Book

Use console input to add contacts one at a time.
Manage multiple contacts with a Collection Class (List or similar).
Branch: UC4_MultipleContacts
UC 5
✅ Multiple Address Books

Support multiple Address Books, each with a unique name.
Maintain a Dictionary of AddressBook names mapped to AddressBook instances.
Branch: UC5_MultipleAddressBooks
UC 6
✅ Prevent Duplicate Entries in an Address Book

Duplicate check based on First Name + Last Name.
Override Equals() and GetHashCode() methods.
Branch: UC6_PreventDuplicate
UC 7
✅ Search Person by City or State Across Address Books

Search across multiple AddressBooks.
Branch: UC7_SearchByCityState
UC 8
✅ View Persons by City or State

Maintain a Dictionary of City → Persons and State → Persons.
Branch: UC8_ViewByCityState
UC 9
✅ Count Contacts by City or State

Return a count of persons in each City/State.
Branch: UC9_CountByCityState
UC 10
✅ Sort Entries Alphabetically by Person’s Name

Sort contact list alphabetically.
Override ToString() for clean output.
Branch: UC10_SortByName
UC 11
✅ Sort Entries by City, State, or Zip

Provide multiple sorting options.
Branch: UC11_SortByCityStateZip
UC 12
✅ Read/Write Address Book to a File (File I/O)

Use C# File I/O for data persistence.
Branch: UC12_FileIO
UC 13
✅ Read/Write Address Book as CSV File

Use OpenCSV Library (or equivalent in C# like CsvHelper).
Branch: UC13_CSVFile
UC 14
✅ Read/Write Address Book as JSON File

Use GSON Library (or equivalent in C# like Newtonsoft.Json).
Branch: UC14_JSONFile
UC 15
✅ Read/Write Address Book to JSON Server (Cloud Server)

Use RESTAssured.NET (or equivalent REST Client in C#).
Branch: UC15_JSONServer
UC 16
✅ Multi-Threading for Non-Blocking IO Operations

Ensure I/O and network operations don't block the main thread.
Use Multi-Threading for CURD on CSV, JSON, JSONServer.
Branch: UC16_MultiThreading
UC 17
✅ Save Address Book to Database

Persist data into an SQL Database.
Follow Open/Closed Principle to add new data sources without breaking the existing code.
Branch: UC17_DatabaseIntegration
UC 18
✅ Thank You Message

Wrap up and display a Thank You message after operations.
Branch: UC18_ThankYou
🛠️ Technologies Used
Tech	Details
IDE	Visual Studio
Language	C#
Libraries	CsvHelper, Newtonsoft.Json
Database	SQL Server / SQLite
REST Client	RESTAssured.NET / HttpClient
Threading	System.Threading.Tasks
💻 How to Run the Project
Clone the repository:
bash
Copy
Edit
git clone https://github.com/yourusername/AddressBookSystem.git
Open the solution in Visual Studio.
Checkout to the desired UC branch:
bash
Copy
Edit
git checkout UC1_AddContact
Run the AddressBookMain class.
✨ Contribution Workflow
Create a branch for each Use Case:
bash
Copy
Edit
git checkout -b UC1_AddContact
Commit changes with clear messages:
bash
Copy
Edit
git commit -m "UC1: Added functionality to add contact"
Push your branch:
bash
Copy
Edit
git push origin UC1_AddContact
Create Pull Requests to main.
✔️ Code Guidelines
Follow Naming Conventions (PascalCase for classes/methods, camelCase for variables).
Ensure Proper Indentation and Clean Code.
Comments where necessary for clarity.
Conduct Code Reviews before merging.
📚 Version Control Best Practices
Use meaningful commit messages.
Avoid large commits; commit frequently.
Merge after review from peers or maintainers.
🙏 Thank You!
This project is a comprehensive example of using OOP, Collections, File Handling, Database, REST API, and Multi-Threading concepts in C#.