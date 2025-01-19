using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;
using SQLitePCL;

namespace Fluffy_Paw.Models
{
    //Create the Model class
    public class Users
    {
        //User register data
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public Users(string UserName, string UserEmail, string UserPassword)
        {
            name = UserName;
            email = UserEmail;
            password = UserPassword;
        }


        //This code creates the SQLite database and stores it in the application's local data store.
        public async static void InitializeDatabase()
        {

            await ApplicationData.Current.LocalFolder.CreateFileAsync("Register.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Register.db");

            //Path to the DB file
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                //Sql statment to create the table and~
                string tableCommand = "CREATE TABLE IF NOT EXISTS" +
                    " userInfo (userName NVARCHAR(100) PRIMARY KEY," +
                    "userEmail NVARCHAR(100) NOT NULL," +
                    "userPassword NVARCHAR(100) NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
                db.Close();
            }
        }

        //Inserts data into the SQLite database.
        //This code uses parameters in the query to prevent SQL injection attacks.
        public static void AddData(string Name, string Email, string Password)
        {

            //Check name, email and password is not empty
            if (!Name.Equals("") && !Email.Equals("") && !Password.Equals(""))
            {

                string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Register.db");

                using (SqliteConnection db =
                  new SqliteConnection($"Filename={dbpath}"))
                {
                    db.Open();

                    SqliteCommand insertCommand = new SqliteCommand();
                    insertCommand.Connection = db;

                    // With the three parameters, it allows to add a value into them
                    insertCommand.CommandText = "INSERT INTO userInfo VALUES(@userName, @userEmail, @userPassword);";
                    insertCommand.Parameters.AddWithValue("@userName", Name);
                    insertCommand.Parameters.AddWithValue("@userEmail", Email);
                    insertCommand.Parameters.AddWithValue("@userPassword", Password);

                    insertCommand.ExecuteReader();

                    db.Close();
                }

            }

        }


        //Retrieve the records of the table
        public static List<Users> GetData()
        {
            List<Users> usersList = new List<Users>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Register.db");

            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string selectCmd = "SELECT userName, userEmail, userPassword FROM userInfo";
                SqliteCommand cmdGet = new SqliteCommand(selectCmd, db);


                SqliteDataReader query = cmdGet.ExecuteReader();

                //Run until the reader has data
                while (query.Read())
                {
                    //Add the data to usersList
                    usersList.Add(new Users(query.GetString(0), query.GetString(1), query.GetString(2)));
                }
            }

            return usersList;
        }

        //Login check
        public static int CheckLogin(string Id, string Password)
        {

            //DB conncetion
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Register.db");

            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                //Check if the database has the enterd password and Id in the database
                string checkCmd = "SELECT COUNT(*) FROM userInfo WHERE userPassword = @Password AND userName = @Id";
                SqliteCommand cmdCheck = new SqliteCommand(checkCmd, db);
                cmdCheck.Parameters.AddWithValue("@Password", Password);
                cmdCheck.Parameters.AddWithValue("@Id", Id);


                //If the registered user who has the same ID and password is stored in the database,
                //Initializing 1 into the variable. If is not, stores 0

                int obj = Convert.ToInt32(cmdCheck.ExecuteScalar());

                return obj;
            }
        }

    }


}
