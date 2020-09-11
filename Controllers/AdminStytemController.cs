using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hy.Admin.Controllers
{
    public class AdminStytem : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult View23()
        {
            return View();
        }
    }
}
