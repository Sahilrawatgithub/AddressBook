# 📒 Address Book System

Welcome to the **Address Book System** project!  
This program demonstrates **Object-Oriented Programming (OOP)** concepts in **C#**, along with advanced features such as **File I/O**, **Database Interaction**, **Cloud Server Integration**, and **Multi-Threading**.

---

## 🌟 Project Outcomes

By working on this project, you will gain hands-on experience in:

✅ **File Handling (File I/O)**  
✅ **Database CRUD Operations**  
✅ **Cloud Server Communication (REST APIs)**  
✅ **Multi-Threading for Non-Blocking I/O or Network Calls**

---

## 🚀 Getting Started

- **IDE**: Visual Studio  
- **Language**: C#  
- **Version Control**: Git  
- **Branch Strategy**: Each **Use Case (UC)** is implemented in a separate Git branch and merged into the `main` branch.  
- **Code Quality**: Follows clean code principles, naming conventions, and proper indentation.  
- **Review Process**: Git commit messages and version history are maintained and reviewed.

---

## 🎯 Features & Use Cases

| UC #  | Feature Description | Git Branch |
|-------|---------------------|------------|
| **UC 0** ✅  | Display Welcome Message in `AddressBookMain` | `UC0_WelcomeMessage` |
| **UC 1** ✅  | Add a New Contact (First Name, Last Name, Address, City, State, Zip, Phone Number, Email) | `UC1_AddContact` |
| **UC 2** ✅  | Edit an Existing Contact by Name | `UC2_EditContact` |
| **UC 3** ✅  | Delete a Contact by Name | `UC3_DeleteContact` |
| **UC 4** ✅  | Add Multiple Persons to Address Book | `UC4_MultipleContacts` |
| **UC 5** ✅  | Manage Multiple Address Books (Dictionary of Address Books) | `UC5_MultipleAddressBooks` |
| **UC 6** ✅  | Prevent Duplicate Entries (Override `Equals()` & `GetHashCode()`) | `UC6_PreventDuplicate` |
| **UC 7** ✅  | Search Persons by City or State Across Address Books | `UC7_SearchByCityState` |
| **UC 8** ✅  | View Persons Grouped by City or State | `UC8_ViewByCityState` |
| **UC 9** ✅  | Count Contacts by City or State | `UC9_CountByCityState` |
| **UC 10** ✅ | Sort Contacts Alphabetically by Name | `UC10_SortByName` |
| **UC 11** ✅ | Sort Contacts by City, State, or Zip Code | `UC11_SortByCityStateZip` |
| **UC 12** ✅ | Read/Write Address Book to a Text File (File I/O) | `UC12_FileIO` |
| **UC 13** ✅ | Read/Write Address Book as CSV (using `CsvHelper`) | `UC13_CSVFile` |
| **UC 14** ✅ | Read/Write Address Book as JSON (using `Newtonsoft.Json`) | `UC14_JSONFile` |
| **UC 15** ✅ | REST API Integration with JSON Server | `UC15_JSONServer` |
| **UC 16** ✅ | Multi-Threading for Efficient I/O and Network Calls | `UC16_MultiThreading` |
| **UC 17** ✅ | Save Address Book to Database (SQL Server/SQLite) | `UC17_DatabaseIntegration` |
| **UC 18** ✅ | Display a Thank You Message | `UC18_ThankYou` |

---

## 🛠️ Technologies & Libraries

- **Language**: C#  
- **IDE**: Visual Studio  
- **Version Control**: Git  
- **Libraries**:
  - `CsvHelper` (for CSV file operations)
  - `Newtonsoft.Json` (for JSON operations)
- **Database**: SQL Server / SQLite  
- **REST Client**: `HttpClient`  
- **Threading**: `System.Threading.Tasks`

---

## 💻 How to Run the Project Locally

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/yourusername/AddressBookSystem.git
