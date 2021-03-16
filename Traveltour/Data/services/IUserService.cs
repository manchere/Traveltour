using System.Collections.Generic;

namespace Traveltour.Data.services
{
    public interface IUserService
    {
        User GetUserById(int userId);
        void AddUser(User user);

        void DeleteUser(int userId);
        void DeleteUsers(int[] ids);

        void UpdateUser(int userId, User user);

        List<User> GetAllUsers();
    }
}