using MyWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApi.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "Alice", SurName = "Johnson", Email = "alice@example.com", Phone = "1234567890", Admin = true, 
                    WorkExperiences = new List<WorkExperience>
                    {
                        new WorkExperience { Id = 1, Company = "Company A", Role = "Developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2021, 1, 1) },
                        new WorkExperience { Id = 2, Company = "Company B", Role = "Manager", StartDate = new DateTime(2018, 1, 1), EndDate = new DateTime(2019, 1, 1) }
                    },
                    Educations = new List<Education>
                    {
                        new Education { Id = 1, School = "School A", Degree = "Bachelor", StartDate = new DateTime(2015, 1, 1), EndDate = new DateTime(2019, 1, 1) },
                        new Education { Id = 2, School = "School B", Degree = "Master", StartDate = new DateTime(2019, 1, 1), EndDate = new DateTime(2021, 1, 1) }
                    }
                },
                new User { Id = 1, Name = "John", SurName = "Johnson", Email = "john@example.com", Phone = "1234567890", Admin = true, 
                    WorkExperiences = new List<WorkExperience>
                    {
                        new WorkExperience { Id = 1, Company = "Company c", Role = "Developer", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2021, 1, 1) },
                        new WorkExperience { Id = 2, Company = "Company D", Role = "FullStackDev", StartDate = new DateTime(2018, 1, 1), EndDate = new DateTime(2019, 1, 1) }
                    },
                    Educations = new List<Education>
                    {
                        new Education { Id = 1, School = "School C", Degree = "Bachelor", StartDate = new DateTime(2015, 1, 1), EndDate = new DateTime(2019, 1, 1) },
                        new Education { Id = 2, School = "School D", Degree = "Master", StartDate = new DateTime(2019, 1, 1), EndDate = new DateTime(2021, 1, 1) }
                    }
                },
                
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User GetUserByID(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User user)
        {
            user.Id = _users.Max(u => u.Id) + 1;
            _users.Add(user);
        }

        public void updatedUser(int id, User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.SurName = user.SurName;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.Admin = user.Admin;
                existingUser.WorkExperiences = user.WorkExperiences;
                existingUser.Educations = user.Educations;
            }
        }

        public void deleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}