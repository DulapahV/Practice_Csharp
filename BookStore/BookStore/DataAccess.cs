using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class DataAccess
    {
        public const string dbpath = "Customer.db";  //Declare default database path
        private static object createTable;

        // Create database
        public static void InitializeDatabase() //Create table
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS CustomerTable (uid INTEGER PRIMARY KEY, " +
                    "username_entry NVARCHAR(50) NULL, " +
                    "password_entry NVARCHAR(50) NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }


        // Write data to database
        public static void AddData(string username, string password)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO CustomerTable VALUES (NULL, @username_entry, @password_entry);";
                insertCommand.Parameters.AddWithValue("@username_entry", username);
                insertCommand.Parameters.AddWithValue("@password_entry", password);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }


        // Get data from database
        public static List<string> GetData() //Get data from database
        {
            List<String> entries = new List<string>();

            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT username_entry, password_entry from CustomerTable", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add($"{query.GetString(0)} {query.GetString(1)}");
                }

                db.Close();
            }
            return entries;
        }
    }
}
