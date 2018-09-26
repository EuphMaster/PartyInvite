using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvite1.Models;

namespace PartyInvite1.Controllers
{
    public class View : Controller
    {
        // GET: Home
        public ViewResult Index()
        { 
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
                timeOfDay = "Good Morning";
            else if (hour < 18)
                timeOfDay = "Afternoon";
            else timeOfDay = "Good Eveneing";
            ViewBag.Greeting = timeOfDay;
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party planner
                return View("Thanks", guestResponse);
            }
            else
            {
                //There is a validation error
                return View();
            }
        }
    }
}