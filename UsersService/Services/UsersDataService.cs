using System;
using System.Collections.Generic;
using UsersService.ViewModels;

namespace UsersService.Services
{
    public class UsersDataService : IUsersDataService
    {
        private List<UserModel> allUsers;

        public UsersDataService()
        {
            allUsers = new List<UserModel> {
                new UserModel
                {
                    Id = 1,
                    FirstName = "User1",
                    LastName = "Mocked",
                    Email = "user1@something.com"
                },
                new UserModel
                {
                    Id = 2,
                    FirstName = "User2",
                    LastName = "Mocked",
                    Email = "user2@something.com"
                },
                new UserModel
                {
                    Id = 3,
                    FirstName = "User3",
                    LastName = "Mocked",
                    Email = "user3@something.com"
                },
            };
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return allUsers;
        }

        public UserModel GetUserById(int userId)
        {
            var foundUser = allUsers.Find(user => user.Id == userId);
            return foundUser;
        }

        public UserModel CreateUser(UserModel newUser)
        {
            newUser.Id = allUsers.Count + 1;
            allUsers.Add(newUser);
            return newUser;
        }

        public UserModel UpdateUser(int userId, UserModel dirtyUser)
        {
            var foundUser = allUsers.Find(user => user.Id == userId);
            if (foundUser == null)
            {
                return null;
            }
            foundUser.FirstName = dirtyUser.FirstName;
            foundUser.LastName = dirtyUser.LastName;
            foundUser.Email = dirtyUser.Email;
            return foundUser;
        }

        public bool DeleteUser(int userId)
        {
            var foundUser = allUsers.Find(user => user.Id == userId);
            if (foundUser == null)
            {
                return false;
            }
            allUsers.Remove(foundUser);
            return true;
        }


    }
}
