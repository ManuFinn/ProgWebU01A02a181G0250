using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U01A02a181G0250.Models;

namespace U01A02a181G0250.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index( CalificacionesViewModel vm)
        {
            return View(vm);
        }

        public IActionResult CalificacionFinal (int Calif01, int Calif02, int Calif03)
        {
            return Ok((Calif01 + Calif02 + Calif03) / 3);
        }
    }
}
