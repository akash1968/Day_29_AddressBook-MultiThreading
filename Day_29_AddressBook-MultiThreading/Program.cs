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
        }
    }
}
