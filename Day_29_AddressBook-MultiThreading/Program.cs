// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Day_29_AddressBook_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System using MultiThreading");
            ///Creating instance class of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///UC16 Retrieve all the contact details from the DB
            repository.RetrieveAllContactDetails();
            /// UC17 Updates the column specified of the existing contact using name.
            Console.WriteLine(repository.UpdateExistingContactUsingByName("Akhilesh", "Singh", "Akhilesh@gmail.com") ? "Updated Succesfully" : "Updated Failed");
            /// UC18 Retrieving the data from the address book entered within a date frame
            repository.RetrieveAllTheContactAddedInBetweenADate(Convert.ToDateTime("5/12/2018"));
            /// UC19 Retrieve number of Contacts in the Database by City or State
            repository.RetrieveNumberOfContactsByCityOrState();

        }
    }
}
