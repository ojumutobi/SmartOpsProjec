using SmartOpsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool Register(User user);

        bool IsUniqueUser(User user);
        bool Authenticate(User user);
        User LogOut();

    }
}
