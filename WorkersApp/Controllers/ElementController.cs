using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkersApp.Data;

namespace WorkersApp.Controllers
{
    public class ElementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ElementController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            //string user = HttpContext.User.ToString();

            return View("string");
        }
    }
}