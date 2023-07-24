using Answer3.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Answer3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index(string selectedCity)
        {
            List<ContactModel> contact = new List<ContactModel> // We add some cities to our model to select them from the dropdown menu.
        {
              new ContactModel { City="İstnbul"},
              new ContactModel { City="Ankara"},
              new ContactModel {City = "Bursa"},
              new ContactModel {City = "Antalya"}
        };
            ViewBag.SelectedCity = selectedCity; // We carry the selectedCity to View with ViewBag.


            return View(contact);
        }
        [HttpPost]
        public IActionResult Add(ContactModel model)
        {
            return Json(new { message = "Kullanıcı bilgileri başarıyla kaydedildi!" }); // returnin json type to use it with ajax         
        }
        public IActionResult getDatas()
        {
            return View();
        }
      

    }
}
