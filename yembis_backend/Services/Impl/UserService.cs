using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using yembis_backend.Helpers;
using yembis_backend.Models;

namespace yembis_backend.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
      

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
          
        }

        private readonly List<User> _users = new()
    {
      new User{ UserID = 1, UserName = "pi", Password = "test"},

    };

        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.UserName == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserID", user.UserID.ToString()),
           
                    new Claim("Username", user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        /*
        private readonly List<User> _users = new()
    {
      new User{ UserID = 1, UserName = "pi", Password = "test"},
   
    };

        public string Login(string userName, string password)
        {
            var user = _users.SingleOrDefault(x => x.UserName == userName && x.Password == password);

            if (user == null)
            {
                return string.Empty;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(JWT.TOKEN);

            var tokenDesciptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
          new Claim(ClaimTypes.Name, user.UserName)
        
              }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDesciptor);
            user.Token = tokenHandler.WriteToken(token);
            return user.Token;
        }*/
    }
}
