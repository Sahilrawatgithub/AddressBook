# 📒 Address Book System

Welcome to the **Address Book System** project!  
This program demonstrates **Object-Oriented Programming** concepts in **C#**, along with advanced features such as **File I/O**, **Database interactions**, **Cloud Server integration**, and **Multi-Threading**.

---

## 🌟 Outcome

By the end of this project, you will be able to:

- Work with File Handles (**File I/O**)
- Perform operations using **Databases**
- Save data to a **Cloud Server**
- Use **Multi-Threading** for I/O or network calls

---

## 🚀 Getting Started

- **IDE**: Visual Studio  
- **Language**: C#  
- **Version Control**: Git  
- **Branch Strategy**: Every **Use Case (UC)** is implemented in a separate Git branch and merged into the `main` branch.  
- **Code Hygiene**: Follows naming conventions, indentation, and clean code practices.  
- **Review Guidelines**: Git check-in comments and version history are monitored.

---

## 🎯 Features & Use Cases (UC)

| UC | Feature Description | Branch |
|-----|----------------------|--------|
| **UC 0** ✅ | Display Welcome Message in `AddressBookMain` | `UC0_WelcomeMessage` |
| **UC 1** ✅ | Add a New Contact (First Name, Last Name, Address, City, State, Zip, Phone Number, Email) | `UC1_AddContact` |
| **UC 2** ✅ | Edit an Existing Contact by Name | `UC2_EditContact` |
| **UC 3** ✅ | Delete a Contact by Name | `UC3_DeleteContact` |
| **UC 4** ✅ | Add Multiple Persons to Address Book | `UC4_MultipleContacts` |
| **UC 5** ✅ | Multiple Address Books with unique names (Dictionary Implementation) | `UC5_MultipleAddressBooks` |
| **UC 6** ✅ | Prevent Duplicate Entries in an Address Book (Override `Equals()` and `GetHashCode()`) | `UC6_PreventDuplicate` |
| **UC 7** ✅ | Search Person by City or State Across Address Books | `UC7_SearchByCityState` |
| **UC 8** ✅ | View Persons by City or State (Dictionary Mapping) | `UC8_ViewByCityState` |
| **UC 9** ✅ | Count Contacts by City or State | `UC9_CountByCityState` |
| **UC 10** ✅ | Sort Entries Alphabetically by Person’s Name | `UC10_SortByName` |
| **UC 11** ✅ | Sort Entries by City, State, or Zip | `UC11_SortByCityStateZip` |
| **UC 12** ✅ | Read/Write Address Book to a File (File I/O) | `UC12_FileIO` |
| **UC 13** ✅ | Read/Write Address Book as CSV File (`CsvHelper` Library) | `UC13_CSVFile` |
| **UC 14** ✅ | Read/Write Address Book as JSON File (`Newtonsoft.Json` Library) | `UC14_JSONFile` |
| **UC 15** ✅ | Read/Write Address Book to JSON Server (Cloud Server) using REST API | `UC15_JSONServer` |
| **UC 16** ✅ | Multi-Threading for Non-Blocking IO Operations | `UC16_MultiThreading` |
| **UC 17** ✅ | Save Address Book to Database (SQL Server / SQLite) | `UC17_DatabaseIntegration` |
| **UC 18** ✅ | Display a Thank You Message at the end of operations | `UC18_ThankYou` |

---