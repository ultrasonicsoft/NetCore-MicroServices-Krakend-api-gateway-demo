using System;
using System.Collections.Generic;
using UsersService.ViewModels;

namespace UsersService.Services
{
    public interface IUsersDataService
    {
        IEnumerable<UserModel> GetAllUsers();
        UserModel GetUserById(int userId);
        UserModel CreateUser(UserModel newUser);
        UserModel UpdateUser(int userId, UserModel dirtyUser);
        bool DeleteUser(int userId);
    }
}
