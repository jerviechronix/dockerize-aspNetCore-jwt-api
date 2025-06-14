using dockerize_aspNetCore_jwt_api.Models;

namespace dockerize_aspNetCore_jwt_api.Services;

public class UserService
{
    private readonly List<User> _users = new();

    public bool Register(User user)
    {
        if (_users.Any(u => u.Username == user.Username))
            return false;

        _users.Add(user);
        return true;
    }

    public User? Authenticate(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}
