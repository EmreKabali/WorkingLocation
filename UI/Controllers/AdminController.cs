using Business.Manager.Interface;
using Entity.DTO.AddModels;
using Entity.DTO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserBiz _userBiz;
     

        public AdminController(IUserBiz userBiz)
        {
            _userBiz = userBiz;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserList()
        {

            return View();
        }


        public IActionResult AddUser()
        {
            var userViewModel = new AddUserViewModel ();

            userViewModel.managerList = getManagerList();

            return View(userViewModel);
        }


        [HttpPost]
        public IActionResult AddUser(AddUserViewModel user)
        {

            try
            {

            }
            catch (Exception ex)
            {

                ViewData["NotificationType"] = "Error";
                ViewData["NotificationContent"] = ex.Message;
            }
            return View();
        }


        [HttpGet]
        public IActionResult Department()
        {
            var departmentViewModel = new AddDepartmentViewModel();
            try
            {

            }
            catch (Exception ex)
            {

                ViewData["NotificationType"] = "Error";
                ViewData["NotificationContent"] = ex.Message;
            }
            return View(departmentViewModel);
        }

        [HttpPost]
        public IActionResult Department(AddDepartmentViewModel department)
        {

            if (!ModelState.IsValid)
            {
                ViewData["NotificationType"] = "Warning";
                ViewData["NotificationContent"] = $" There are {ModelState.ErrorCount} error.";
                return View(department);
            }

            return View();
        }

        public List<SelectListItem> getManagerList()
        {
            var users = _userBiz.GetList().EntityList.Select(x=>new SelectListItem(text:x.Name+' '+ x.Surname ,value:x.Id.ToString())).ToList();

            return users;
            
        }
    }
}
