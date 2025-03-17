using MyWebApi.Models;

public interface IUserService
{
    IEnumerable<User> GetUsers();
    User GetUserByID(int ID);
    void AddUser(User user);
    void updatedUser(int ID, User user);
    void deleteUser(int ID);
    
}