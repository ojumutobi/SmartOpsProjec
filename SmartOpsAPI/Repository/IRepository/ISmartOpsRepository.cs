using SmartOpsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Repository.IRepository
{
   
    public interface ISmartOpsRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int userId);

        User GetUserRecord(int userId);
    }
}
