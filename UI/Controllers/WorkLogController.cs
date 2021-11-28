using Business.Manager.Interface;
using Entity.DTO.ResponseDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class WorkLogController : Controller
    {

        IWorkLogTypeBiz workLogTypeBiz;
        public WorkLogController(IWorkLogTypeBiz workLogTypeBiz)
        {
            this.workLogTypeBiz = workLogTypeBiz;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateWorkLog()
        {
            return View();
        }


        public JsonResult LoadWorkLogTypes()
        {
            var response =new  WorkLogTypeResponse();

            response = workLogTypeBiz.GetList();

            return Json(response.EntityList);

        }

    }
}
