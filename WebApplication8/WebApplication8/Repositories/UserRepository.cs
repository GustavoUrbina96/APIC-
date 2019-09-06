using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class UserRepository
    {
        private List<UserModel> Users = new List<UserModel>();
        public List<UserModel> GetUsers()
        {
            return Users == null ? null : Users;
        }

        public void AddUser(UserModel newUser)
        {
            Users.Add(newUser);
        }

        public UserModel GetUserByID(int id)
        {
            return Users.Find(x => x.Id.Equals(id));
        }

        public void DeleteUser(int id)
        {
            Users.Remove(GetUserByID(id));
        }

        public void UpdateUser(int id, UserModel User)
        {
            var userToUpdate = GetUserByID(id);
            userToUpdate.FirstName = User.FirstName;
            userToUpdate.LastName = User.LastName;
        }
    }
}
