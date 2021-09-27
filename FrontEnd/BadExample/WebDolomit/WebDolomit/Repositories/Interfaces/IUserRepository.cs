using System.Collections.Generic;
using System.Web.Security;
using WebDolomit.Models;

namespace WebDolomit.Repositories
{
    public interface IUserRepository
    {
        MembershipUser GetMembershipUserByName(string userName);
        bool CreateUser(string userName, string password, string email,
            string lastName, string firstName, string middleName);
        bool ValidateUser(string userName, string pas);
        bool SaveUser(User user);

    }
}
