using PharmacyInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmacyInventory.Web.Controllers
{
    [Authorize]
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult Index()
        {
            var model = new VendorListItem[0];
            return View(model);
        }
    }
}