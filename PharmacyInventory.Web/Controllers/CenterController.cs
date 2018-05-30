using PharmacyInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmacyInventory.Web.Controllers
{
    [Authorize]
    public class CenterController : Controller
    {
        // GET: Center
        public ActionResult Index()
        {
            var model = new CenterListItem[0];
            return View(model);
        }

        // Add method here vvvv
        //Get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CenterCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}