using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class MediaController : Controller
    {
        [Route("/portal/media")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/portal/media/add-file")]
        public IActionResult AddFile()
        {
            return View();
        }
        [Route("/portal/media/files")]
        public IActionResult Files()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
