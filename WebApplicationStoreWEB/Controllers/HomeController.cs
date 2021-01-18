using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationStoreBLL.interfaces;
using WebApplicationStoreDAL.Entities;
using WebApplicationStoreWEB.Models;

namespace WebApplicationStoreWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryGetProduct<Product> _repository;
        public HomeController(IRepositoryGetProduct<Product> repository)
        {
            _repository = repository ?? throw new ArgumentNullException();
        }

        public IActionResult GetCatalogWithProduct(string catalog)
        {
            IEnumerable<Product> products = _repository.GetProducts(catalog);
            return View(products);
        }

        public IActionResult GetCatalogMobileProductStart()
        {
            IEnumerable<Product> products = _repository.GetProducts("Mobile phone"); // страница по умолчанию согласно заданию
            return View(products);
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Home(string valueName)
        {
            string _userKey = "userName";

            if (!string.IsNullOrEmpty(valueName))
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(_userKey, valueName, cookieOptions);
                
                return Redirect("Home");
            }
            else
            {
                return View();
            }

        }

        public IActionResult Contacts()
        {
            return View("Contacts");
        }

        public IActionResult About()
        {
            return View("About");
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
