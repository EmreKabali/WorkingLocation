using Business.Manager.Interface;
using Entity.DTO.AddModels;
using Entity.DTO.Filters;
using Entity.DTO.RequestDTO;
using Entity.DTO.ViewModels;
using Entity.Models;
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
        private readonly IDepartmentBiz _departmentBiz;


        public AdminController(IUserBiz userBiz, IDepartmentBiz departmentBiz)
        {
            _userBiz = userBiz;
            _departmentBiz = departmentBiz;
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
            var userViewModel = new AddUserViewModel();

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
            var request = new DepartmentRequest { Entity = new Entity.Models.Department() };
            if (!ModelState.IsValid)
            {
                ViewData["NotificationType"] = "Warning";
                ViewData["NotificationContent"] = $" There are {ModelState.ErrorCount} error.";
                return View(department);
            }


            request.Entity.Name = department.Name;
            request.Entity.Description = department.Description;
            request.Entity.AddedBy = 1;

            var result = _departmentBiz.Add(request);
            return RedirectToAction("DepartmentList");
        }


        public IActionResult DepartmentList(DepartmentFilter filter)
        {
            var departmentFilter = new DepartmentFilter();

            departmentFilter.Departments = _departmentBiz.GetList().EntityList;

            return View(departmentFilter);
        }

        public List<SelectListItem> getManagerList()
        {
            var users = _userBiz.GetList().EntityList.Select(x => new SelectListItem(text: x.Name + ' ' + x.Surname, value: x.Id.ToString())).ToList();

            return users;

        }
    }
}
