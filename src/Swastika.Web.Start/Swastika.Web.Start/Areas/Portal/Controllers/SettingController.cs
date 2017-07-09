using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class SettingController : Controller
    {
        [Route("/portal/setting")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/portal/setting/generals")]
        public IActionResult Generals()
        {
            return View();
        }

        [Route("/portal/setting/cultures")]
        public IActionResult Cultures()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
