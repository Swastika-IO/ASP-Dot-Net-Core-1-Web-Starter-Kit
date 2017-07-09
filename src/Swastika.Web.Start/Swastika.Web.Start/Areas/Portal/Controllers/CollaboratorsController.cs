using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Swastika.Web.Start.Areas.Portal.Controllers
{
    [Area("Portal")]
    public class CollaboratorsController : Controller
    {
        [Route("/portal/collaborators")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/portal/collaborators/add-member")]
        public IActionResult AddMember()
        {
            return View();
        }
        [Route("/portal/collaborators/members")]
        public IActionResult Members()
        {
            return View();
        }
        [Route("/portal/collaborators/roles")]
        public IActionResult Roles()
        {
            return View();
        }
        [Route("/portal/collaborators/permission")]
        public IActionResult Permission()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
