using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDolomit.Providers;

namespace WebDolomit.Repositories
{
    public class DataManager
    {
        private IUserRepository userRepository;
        private CustomMembershipProvider membershipProvider;
        private ILogicRepository logicRepository;

        public DataManager(
            IUserRepository userRepository,
            CustomMembershipProvider membershipProvider,
            ILogicRepository logicRepository
           )
        {
            this.userRepository = userRepository;
            this.membershipProvider = membershipProvider;
            this.logicRepository = logicRepository;
        }

        public IUserRepository IUsers { get { return userRepository; } }
        public CustomMembershipProvider CustomProvider { get { return membershipProvider; } }
        public ILogicRepository ILogic { get { return logicRepository; } }
    }
}