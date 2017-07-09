using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class ContentsController : Controller
    {
        [Route("/portal/contents")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/portal/contents/articles")]
        public IActionResult Articles()
        {
            return View();
        }

        [Route("/portal/contents/add-article")]
        public IActionResult AddArticle()
        {
            return View();
        }

        [Route("/portal/contents/categories")]
        public IActionResult Categories()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
