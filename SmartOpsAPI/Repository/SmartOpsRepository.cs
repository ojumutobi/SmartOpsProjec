using SmartOpsAPI.Models;
using SmartOpsAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Repository
{
    public class SmartOpsRepository : ISmartOpsRepository
    {
        public SmartOpsRepository()
        {

        }
        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserRecord(int userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
