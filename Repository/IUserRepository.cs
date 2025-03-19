using CvAPI2.Models;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
    User GetUserById(int id);
    void AddUser(User user);
    void UpdateUser(int id, User user);
    void DeleteUser(int id);
}