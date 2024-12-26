using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Timers;

namespace Demo.Controllers
{
    public class ContactController : Controller
    {
        private readonly string email = "contact@bestscore.com";
        private readonly string address = "New york,USA";
        public IActionResult Index()
        {
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactDto model)
        {
            if(!ModelState.IsValid) {
                return View();
            }
            // Store the data to the database
            ModelState.Clear();
            ViewBag.Message = "Your message is recieved successfully!";
            return View(model);
        }
    }
}
