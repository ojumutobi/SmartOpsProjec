using SmartOpsAPI.Dtos;
using SmartOpsAPI.Models;
using SmartOpsWeb.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartOpsWeb.Repository
{
    public class SmartOpsRepository : ISmartOpsRepository
    {
        public Task<int> CountAllUsers()
        {
            throw new NotImplementedException();
        }

        //public async Task<int> CountAllUsers()
        //{
        //    int count = 0;

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
        //        var response =  client.GetAsync($"users/CountAllUsers");
        //        response.Wait();

        //        var  result = response.Result;

        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = awit result.Content.ReadAsAsync<int>();
        //            readTask.Wait();

        //            count = readTask.Result;

        //        }
        //    }

        //    return count;
        //}

        public bool CreateUser(User usr)
        {
            bool value = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
                var responseTask = client.PostAsJsonAsync("user/Register", usr);

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    //var newlyCreatedUsrTask = result.Content.ReadAsAsync<User>();
                    //newlyCreatedUsrTask.Wait();

                    //var newuser = newlyCreatedUsrTask.Result;
                    //// TempData["SuccessMessage"] = was created Successfully;
                    ///
                    value = true;

                }


            }

            return value;

        }

        //public Task<bool> CreateUserAsync(User usr)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
        //        var response = client.GetAsync($"users/{usr}");
        //        response.Wait();

        //        var result = response.Result;

        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsAsync<UserDto>();
        //            readTask.Wait();

        //            //country = readTask.Result;

        //            return true;
        //        }

        //        return false;
        //    }
        //}

        public UserDto GetUserById(int usrID)
        {
            UserDto country = new UserDto();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
                var response = client.GetAsync($"user/{usrID}");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<UserDto>();
                    readTask.Wait();

                    country = readTask.Result;

                }
            }

            return country;
        }

      

        public IEnumerable<UserDto> GetUsers()
        {
            IEnumerable<UserDto> usrDTO = new List<UserDto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SD.SmartOpsAPIPath);

                var response = client.GetAsync("user");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<UserDto>>();
                    readTask.Wait();

                    usrDTO = readTask.Result;

                }
                return usrDTO;
            }
        }

        public bool UpdateUser(User usr)
        {
            bool value = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
               // var response = client.GetAsync($"users/{usrID}");
                var responseTask = client.PutAsJsonAsync("user/UpdateUserById", usr);

                responseTask.Wait();
                var responseResult = responseTask.Result;

                if (responseResult.IsSuccessStatusCode)
                {
                    value = true;
                }
            }

            return value;
        }

        public bool UpdateUser(int usrID)
        {
            bool return_Value = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SD.SmartOpsAPIPath);
                var response = client.GetAsync($"users/{usrID}");
                response.Wait();
            }

            return return_Value;
        }

        public Task<bool> UpdateUserAsync(User usr)
        {
            throw new NotImplementedException();
        }
    }
}
