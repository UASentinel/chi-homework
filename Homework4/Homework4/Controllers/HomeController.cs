using System.Diagnostics;
using System.Text.RegularExpressions;
using Homework4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            if (!CheckUser(user))
            {
                return View(user);
            }
            return RedirectToAction("Account", user);
        }
        public IActionResult Account(User user)
        {
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private bool CheckUser(User user)
        {
            ModelState.Clear();
            var namePattern = @"^[A-Za-zА-яЀ-ґ]{2,}$";
            var emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            bool result = true;
            if (user.Name == null)
            {
                ModelState.AddModelError("Name", "Empty name");
                result = false;
            }
            if (user.Email == null)
            {
                ModelState.AddModelError("Email", "Empty email");
                result = false;
            }
            if (user.Name != null && !Regex.IsMatch(user.Name, namePattern))
            {
                ModelState.AddModelError("Name", "Invalid name");
                result = false;
            }
            if (user.Email != null && !Regex.IsMatch(user.Email, emailPattern))
            {
                ModelState.AddModelError("Email", "Invalid email");
                result = false;
            }
            return result;
        }
    }
}