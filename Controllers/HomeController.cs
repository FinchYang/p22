using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using p22.Models;
using Microsoft.AspNetCore.Authorization;
namespace p22.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult faren()
        {
            return View();
        }
        public IActionResult birthcertification()
        {
            return View();
        }
        public IActionResult synthesis()
        {
            return View();
        }
        public IActionResult shengyu()
        {
            return View();
        }
        public IActionResult search()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
