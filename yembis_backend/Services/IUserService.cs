using yembis_backend.Models;

namespace yembis_backend.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);    
       /* string Login(string UserName, string Password);*/
    }
}
