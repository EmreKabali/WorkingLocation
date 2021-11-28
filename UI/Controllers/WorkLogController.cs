using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class WorkLogController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateWorkLog()
        {
            return View();
        }


    }
}
