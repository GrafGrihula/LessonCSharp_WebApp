using IdentityModel.Client;
using System;

namespace Timesheets.Authentication
{
    internal sealed class UserService : IUserService
    {
        public const string SecretCode = "THIS IS SOME VERY SECRET STRING!!!";

        TokenResponse IUserService.Authenticate(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
