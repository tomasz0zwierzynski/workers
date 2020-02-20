using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkersApp.Data;
using WorkersApp.Models;

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
        public IActionResult MySalaries()
        {

            string username = User.Identity.Name;
            var positions = _context.Positions.ToList();
            var userSalaries = _context.Salaries.Where(s => s.Worker.Email.Equals(username)).ToList();

            int total = 0;

            var salaryViewModels = new List<SalaryViewModel>();
            userSalaries.ForEach(salary =>
            {
                SalaryViewModel viewModel = new SalaryViewModel();
                viewModel.SalaryID = salary.SalaryID;
                total += salary.SalaryID;

                viewModel.Bonus = salary.Bonus;
                total += salary.Bonus;

                var position = positions.Find(p => p.PositionID == salary.PositionID);
                viewModel.PositionName = position.Name;
                viewModel.PositionAmount = position.Amount;

                salaryViewModels.Add(viewModel);
            });

            ViewData["UserName"] = username;
            ViewData["ViewModel"] = salaryViewModels;
            ViewData["Total"] = total;

            return View("Views/Custom/MySalaries.cshtml");
        }
    }
}