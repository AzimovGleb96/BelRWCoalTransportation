using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Security;
using WebDolomit.DAL;
using WebDolomit.Models;

namespace WebDolomit.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private PrimaryContext _context;
        public EFUserRepository(PrimaryContext context)
        {
            _context = context;
        }

        public bool CreateUser(string userName, string password, string email,
            string lastName, string firstName, string middleName)
        {
            User us = new User
            {
                Login = userName,
                Password = password,
                Email = email,
                FullName = $"{ lastName + " " + firstName + " " + middleName }",               
            };
            bool fl = SaveUser(us);
            return fl;
        }

        public MembershipUser GetMembershipUserByName(string userName)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Login == userName);
                if (user != null)
                {
                    MembershipUser memberUser = new MembershipUser
                        ("CustomMembershipProvider", user.Login, null, user.Email, null, null,
                        false, false, DateTime.Now,
                        DateTime.MinValue, DateTime.MinValue,
                        DateTime.MinValue, DateTime.MinValue);
                    return memberUser;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveUser(User user)
        {
            try
            {
                if (user.ID == 0)
                    _context.Users.Add(user);
                else
                    _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { return false; }
        }

        public bool ValidateUser(string userName, string pas)
        {
            try
            {
                User us = _context.Users.FirstOrDefault(x => x.Login == userName);
                if (us != null && us.Password == pas)
                    return true;
            }
            catch (Exception) { }
            return false;
        }
    }
}