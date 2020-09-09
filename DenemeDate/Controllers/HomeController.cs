using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DenemeDate.Models;
using Microsoft.EntityFrameworkCore;

namespace DenemeDate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserContext _context;
        public HomeController(ILogger<HomeController> logger, UserContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Users> users = _context.Users.ToList();
            return View(users);
        }
        [HttpPost]
        public IActionResult Index(DateTime? startTime, DateTime? endTime)
        {
           var  users = _context.Users.Where(x => x.CreatedDate >= startTime == x.CreatedDate <= endTime).ToList();

            return View(users);
        }

        public IActionResult Search(DateTime startTime, DateTime endTime)
        {
            List<Users> users = _context.Users.Where(x=>x.CreatedDate>=startTime == x.CreatedDate<=endTime).ToList();
            return View(users);
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
    }
}
