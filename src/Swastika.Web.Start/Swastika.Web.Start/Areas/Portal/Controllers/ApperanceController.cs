using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class ApperanceController : Controller
    {
        [Route("/portal/apperance")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("/portal/apperance/menus")]
        public IActionResult Menus()
        {
            return View();
        }

        [Route("/portal/apperance/themes")]
        public IActionResult Themes()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
