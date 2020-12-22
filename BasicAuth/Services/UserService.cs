using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuth.Services
{
    public class UserService : IUserService
    {
        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("me") && password.Equals("Pa$$WoRd");
        }
    }
}
