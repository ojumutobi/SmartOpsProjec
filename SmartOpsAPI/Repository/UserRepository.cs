using SmartOpsAPI.Data;
using SmartOpsAPI.Models;
using SmartOpsAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserRepository _userRepository;
        private ApplicationDbContext _db;
        public UserRepository(IUserRepository userRepository, ApplicationDbContext db)
        {
            _userRepository = userRepository;
            _db = db;

        }

        public bool Authenticate(User user)
        {
            throw new NotImplementedException();
        }

        public bool IsUniqueUser(User user)
        {
            throw new NotImplementedException();
        }

        public User LogOut()
        {
            throw new NotImplementedException();
        }

        public bool Register(User userdata)
        {
            
            User user = new User()
            {
                Name    = userdata.Name,
                Address = userdata.Address,
                Email = userdata.Email,
                Password = userdata.Password,
                PhoneNumber = userdata.PhoneNumber,
                ImageUrl = userdata.ImageUrl,
                Role = userdata.Role,
                Token = userdata.Token,
                IsVisible = userdata.IsVisible,
                DateCreated = userdata.DateCreated

            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return true;
        }

    
    }
}
