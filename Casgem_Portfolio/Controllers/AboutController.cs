﻿using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAboutMe()
        {
            ViewBag.title = db.TblWhoAmI.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = db.TblWhoAmI.Select(x => x.Description).FirstOrDefault();
            ViewBag.mail = db.TblContact.Select(x => x.Mail).FirstOrDefault();
            ViewBag.nameSurname = db.TblContact.Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.age = db.TblContact.Select(x => x.Age).FirstOrDefault();
            ViewBag.city = db.TblContact.Select(x => x.Age).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialAboutMe2()
        {
            return PartialView();
        }

        public PartialViewResult PartialSkillDegree()
        {
            ViewBag.title = db.TblSkillDescription.Select(x => x.SkillDesTitle).FirstOrDefault();
            ViewBag.des = db.TblSkillDescription.Select(x => x.SkillDescription).FirstOrDefault();

            var values = db.TblSkillDegree.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAchievement()
        {
            var values = db.TblAchievement.ToList();

            return PartialView(values);
        }
    }
}