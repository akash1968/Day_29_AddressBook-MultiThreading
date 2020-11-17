// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBConnection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Day_29_AddressBook_MultiThreading
{
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            /// Specifying the connectionString from the sql server connection.
            string connectiongString = @"Data Source=DESKTOP-TSL9UFS;Initial Catalog=AddressBook_System;Integrated Security=True;User ID=akash;Password=1997";
            SqlConnection connection = new SqlConnection(connectiongString);
            return connection;
        }
    }
}