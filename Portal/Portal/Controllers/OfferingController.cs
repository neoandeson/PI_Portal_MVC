using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class OfferingController : Controller
    {
        [Route("list-offer")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("offer-detail")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}