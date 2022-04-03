using IdentityModel.Client;

namespace Timesheets.Authentication
{
    interface IUserService
    {
        TokenResponse Authenticate(string user, string password);
    }
}
