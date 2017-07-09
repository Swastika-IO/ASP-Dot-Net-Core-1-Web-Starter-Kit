using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class PagesController : Controller
    {
        [Route("/portal/pages")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/portal/pages/add-page")]
        public IActionResult AddPage()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
