using Numerical_Stroop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numerical_Stroop.Controllers
{
    public class HomeController : Controller
    {
        public DB db = new DB();

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(WorkerId workerId)
        {
            if (db.WorkerIds.Count(m => m.Code == workerId.Code) != 0)
            {
                ModelState.AddModelError("Code", "This code has already been used");
            }

            if (ModelState.IsValid)
            {
                int group = db.WorkerIds.Count() % 6;
                
                switch (group)
                {
                    case 0:
                        workerId.Group = Group.Financial_High;
                        break;
                    case 1:
                        workerId.Group = Group.Financial_Medium;
                        break;
                    case 2:
                        workerId.Group = Group.Financial_Low;
                        break;
                    case 3:
                        workerId.Group = Group.Control_High;
                        break;
                    case 4:
                        workerId.Group = Group.Control_Medium;
                        break;
                    case 5:
                        workerId.Group = Group.Control_Low;
                        break;
                }

                workerId.Progress = Progress.Consent;
                workerId.IpAddress = Functions.GetUserIP();
                db.WorkerIds.Add(workerId);
                db.SaveChanges();

                return RedirectToAction("Consent", new { id = workerId.Id });
            }

            return View(workerId);
        }

        public ViewResult Consent(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        [HttpPost]
        public ActionResult Consent(int id, FormCollection values)
        {
            if (ModelState.IsValid)
            {
                db.WorkerIds.Find(id).Progress = Progress.Scenario1;
                db.SaveChanges();
                return RedirectToAction("Scenario1", "Scenario", new { id = id });
            }

            return View(values);
        }


        public ActionResult Debrief(int? id)
        {
            return View();
        }
    }
}