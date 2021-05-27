using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteApp
{
    class DataAccess
    {
        public const string dbpath = "Customer.db";  //Declare default path
        private static object createTable;

        public static void InitializeDatabase() //Create table
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS CustomerTable (uid INTEGER PRIMARY KEY, " +
                    "first_Name NVARCHAR(50) NULL, " +
                    "last_Name NVARCHAR(50) NULL, " +
                    "email NVARCHAR(50) NULL)";
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

            }
        }
        public static void AddData(string firstName, string lastName, string email)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO CustomerTable VALUES (NULL, @first_Name, @last_Name, @email);";
                insertCommand.Parameters.AddWithValue("@first_Name", firstName);
                insertCommand.Parameters.AddWithValue("@last_Name", lastName);
                insertCommand.Parameters.AddWithValue("@email", email);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }
        public static List<String> GetData() //Get data from database
        {
            List<String> entries = new List<string>();

            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT first_Name, last_Name, email from CustomerTable", db);


                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add($"{query.GetString(0)} {query.GetString(1)} ({query.GetString(2)})");
                }

                db.Close();
            }

            return entries;
        }
    }
}