using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AddressBook.Models;
using AddressBook.DataProvider;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _repository = null;
        public HomeController(IRepository<User> repository)
        {
            _repository = repository;
        }

        public IActionResult AddressBook()
        {
            ViewData["Message"] = _repository.GetAll();
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["Message"] = new { List = _repository.GetAll(), id };
        
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
