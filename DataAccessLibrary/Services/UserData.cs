using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

// This class provides logic for CRUD operations on dbo.USERS

namespace DataAccessLibrary

{
    public class UserData : IUserData
    {
        // Initialize field for the data access class
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        // Returns a list of users from the database through the LoadData method
        public Task<List<UserModel>> GetAllUsers()
        {
            string sql = "select * from dbo.USERS";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        // Create SQL command to insert user, pass string to data access class along with instance of user class
        public Task NewUser(UserModel user)
        {
            string sql = @"insert into dbo.USERS (USERNAME, USEREMAIL, USERPASSWORD)
                            values (@USERNAME, @USEREMAIL, @PASSWORD);";
            return _db.SaveData(sql, user);
        }
    }
}