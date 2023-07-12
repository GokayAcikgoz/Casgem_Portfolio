using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    [Authorize]
    public class WhoAmIController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblWhoAmI.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateWhoAmI(int id) 
        {
            var value = db.TblWhoAmI.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateWhoAmI(TblWhoAmI p)
        {
            var value = db.TblWhoAmI.Find(p.WhoID);
            value.Title = p.Title;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}