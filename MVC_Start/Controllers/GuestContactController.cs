using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Start.Controllers
{
    public class GuestContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult GuestContact()
        {
            GuestContact contact = new GuestContact
            {
                Name = "Alex Seufert",
                Email = "amseufert@gmail.com",
                Phone = "88888888"
            };
            ViewData["Message"] = "Guest Contact Page";
            // now pass an argument. Takes any object
            return View(contact);
        }
        [HttpPost]
        public IActionResult GuestContact(GuestContact contact)
        {
            ViewData["Message"] = "Guest Contact Page";
            return View(contact);
        }
    }
}
