using SmartOpsAPI.Data;
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

        //private readonly ISmartOpsRepository _smartOpsRepository;

        private ApplicationDbContext _db;

        public SmartOpsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        //public async Task<int> CountAllUsers()
        //{
        //    return await _db.Users.Count();
        //}

        public Task<int> CountAllUsers(string url)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            return _db.Users.Find(userId);
        }

        public User GetUserRecord(int userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {
            return _db.Users.ToList();                
        }

        public ICollection<User> UpdateUser()
        {
            throw new NotImplementedException();
        }
        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved >= 0 ? true : false;
        }
        public bool UpdateUser(User usrData)
        {
             _db.Users.Update(usrData);
            return Save();
        }
    }
}
