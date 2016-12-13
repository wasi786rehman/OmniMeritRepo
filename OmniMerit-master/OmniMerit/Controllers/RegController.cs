using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OmniMerit.Controllers
{
    public class RegController : Controller
    {
        // GET: Reg
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegUser r)
        {
            if (ModelState.IsValid)
            {
                using (OmniDbEntities de = new OmniDbEntities())
                {
                    de.RegUsers.Add(r);
                    de.SaveChanges();
                    ModelState.Clear();
                    r = null;
                    ViewBag.Message = "Successfully registration Done. Please lOgin Now";
                }
            }
            return View(r);
        }
    }
}