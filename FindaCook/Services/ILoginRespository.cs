

using FindaCook.Maui.Models;

namespace FindaCook.Services
{
    public interface ILoginRespository
    {
        Task<User> Login(string email, string password);
    }
}
