using Business.Manager.Interface;
using Entity.DTO.AddModels;
using Entity.DTO.ViewModels;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.WebPages.Html;
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
            var userViewModel = new AddUserViewModel();

            userViewModel.managerList = getManagerList();

            return View();
        }


        [HttpPost]
        public IActionResult AddUser(AddUserModel user)
        {

            try
            {

            }
            catch (Exception ex)
            {

                throw;
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
