using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swastika.Web.Start.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Components")]
        public IActionResult Components()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("/Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
