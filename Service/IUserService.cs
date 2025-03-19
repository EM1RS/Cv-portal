using CvAPI2.Models;

public interface IUserService
{
    IEnumerable<User> GetUsers();
    User GetUserByID(int id);
    void AddUser(User user);
    void updatedUser(int id, User user);
    void deleteUser(int id);
    
}