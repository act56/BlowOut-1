using BlowOut_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut_1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View("Please call Support at <strong><u>801-555-1212.</u></strong> Thank you!");
        }

        public ActionResult Email(string name, string email)
        {

            return View("Index", "Thank you, " + name + "We will send an email to " + email);
        }

    }
}