using SmartOpsAPI.Dtos;
using SmartOpsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsWeb.Repository.IRepository
{
    public interface ISmartOpsRepository
    {
        IEnumerable<UserDto> GetUsers();
        UserDto GetUserById(int usrID);
        Task<int> CountAllUsers();
        bool CreateUser(User usr);
        bool UpdateUser(User usr);


    }
}
