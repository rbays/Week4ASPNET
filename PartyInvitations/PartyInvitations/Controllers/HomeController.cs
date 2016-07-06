using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvitations.Models;

namespace PartyInvitations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TO DO: email response to party organiser
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        
    }
}