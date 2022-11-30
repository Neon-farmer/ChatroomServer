using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    // This is an interface that is extended by the UserData class
    public interface IUserData
    {
        // Read
        Task<List<UserModel>> GetAllUsers();

        // Create, Update, Delete
        Task NewUser(UserModel user);
    }
}