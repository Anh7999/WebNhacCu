using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web12.Models;

namespace web12.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        web1Entities1 db = new web1Entities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getContact(string meta)
        {
            //ViewBag.meta = "lien-he";
            ///ViewBag.meta = meta;
            //var v = from t in db.menus
            //        where  t.hide==true
            //        orderby t.order ascending
            //        select t;
            return View();
        }
    }
}