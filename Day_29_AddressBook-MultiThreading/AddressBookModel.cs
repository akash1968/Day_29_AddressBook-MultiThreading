﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookModel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_29_AddressBook_MultiThreading
{
    /// <summary>
    /// Class to map the relational data base model to a entity.
    /// </summary>
    public class AddressBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string AddressBookType { get; set; }
        public string AddressBookName { get; set; }


    }
}
