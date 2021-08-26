using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartOpsAPI.Dtos;
using SmartOpsAPI.Models;
using SmartOpsWeb.Models;
using SmartOpsWeb.Models.ViewModel;
using SmartOpsWeb.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISmartOpsRepository _smartOpsRepository;

        public HomeController(ILogger<HomeController> logger, ISmartOpsRepository smartOpsRepository)
        {
            _logger = logger;
            _smartOpsRepository = smartOpsRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Dashboard()
        {
            DashVM listofDashVM = new DashVM();

            listofDashVM.DashBoardUserList = _smartOpsRepository.GetUsers();
          
            listofDashVM.TotalUsersInDB = listofDashVM.DashBoardUserList.Count();
            return View(listofDashVM);
        }


        public IActionResult ViewCustomerDetails(int Id)
        {
            var response = _smartOpsRepository.GetUserById(Id);

            if (response == null)
            {
                ModelState.AddModelError("", "Error retrieving User details");
            }

            UserDto usr = new UserDto()
            {
                Address = response.Address,
                Email = response.Email,
                Name = response.Name,
                PhoneNumber = response.PhoneNumber
            };

            return View(usr);
            
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> CreateCustomer(UserDto userDto)
        {
            if (userDto ==null )
            {
                return View();
            }

            User usr = new User()
            {
                Address = userDto.Address,
                Name = userDto.Name,
                Email = userDto.Email,
                Password = userDto.Password,
                PhoneNumber = userDto.PhoneNumber,
                ImageUrl = userDto.ImageUrl,
                IsVisible = 1,
                DateCreated = DateTime.Now
            };

            var create_user_resp =  _smartOpsRepository.CreateUser(usr);

            if (create_user_resp)
            {
                TempData["alert_user_created_successfully"] = $"{userDto.Name} has been created";
            }
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int user_id, int Id)
        {
            var response = _smartOpsRepository.GetUserById(Id);
            
            if (response == null)
            {
                ModelState.AddModelError("","Error retrieving User details");
            }

            UserDto usr = new UserDto()
            {
                Address = response.Address,
                Email = response.Email,
                Name = response.Name,
                PhoneNumber = response.PhoneNumber                
            };
           
            return View(usr);
        }


        [HttpPost]
        public IActionResult UpdateCustomer(User user)
        {

            var result = _smartOpsRepository.UpdateUser(user);

            if (result)
            {
                TempData["alert_user_updated_successfully"] = $"{user.Name} has been updated";
            }

            return RedirectToAction("Dashboard");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
