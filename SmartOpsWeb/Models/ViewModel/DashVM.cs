using SmartOpsAPI.Dtos;
using SmartOpsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsWeb.Models.ViewModel
{
    public class DashVM
    {
        public IEnumerable<UserDto> DashBoardUserList { get; set; }

        public int TotalUsersInDB { get; set; }

        public List<User> User { get; set; }
    }
}
