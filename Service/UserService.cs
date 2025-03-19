using CvAPI2.Models;
using System.Collections.Generic;
using System.Linq;

namespace CvAPI2.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public User GetUserByID(int id)
        {
            return _userRepository.GetUserById(id);
        }
        
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public void updatedUser(int id, User user)
        {
            _userRepository.UpdateUser(id, user);
        }

        public void deleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}