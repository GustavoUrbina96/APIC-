using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public UserModel GetUserById(int id)
        {
            return _userRepository.GetUserByID(id);
        }

        public void DeleteUser(int id) => _userRepository.DeleteUser(id);

        public void AddUser(UserModel newUser) => _userRepository.AddUser(newUser);

        public void UpdateUser(int id, UserModel User) => _userRepository.UpdateUser(id, User);
    }
}
