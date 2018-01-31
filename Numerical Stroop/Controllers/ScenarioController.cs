using Numerical_Stroop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numerical_Stroop.Controllers
{
    public class ScenarioController : Controller
    {
        public DB db = new DB();

        // GET: Scenario
        public ActionResult Scenario1(int id)
        {
            var group = Functions.GetUserGroup(id);

            if (!group.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }
            
            switch (group) {
                case Group.Financial_High:
                    ViewBag.Question1 = Variables.Financial_High_Scenario_1;
                    break;
                case Group.Financial_Medium:
                    ViewBag.Question1 = Variables.Financial_Medium_Scenario_1;
                    break;
                case Group.Financial_Low:
                    ViewBag.Question1 = Variables.Financial_Low_Scenario_1;
                    break;
                case Group.Control_High:
                    ViewBag.Question1 = Variables.Control_High_Scenario_1;
                    break;
                case Group.Control_Medium:
                    ViewBag.Question1 = Variables.Control_Medium_Scenario_1;
                    break;
                case Group.Control_Low:
                    ViewBag.Question1 = Variables.Control_Low_Scenario_1;
                    break;
            }

            if (group.Value == Group.Financial_High || group.Value == Group.Financial_Medium || group.Value == Group.Financial_Low)
            {
                return View("Scenario1_Financial");
            }
            else
            {
                return View("Scenario1_Control");
            }
        }

        [HttpPost]
        public ActionResult Scenario1(Scenario scenarioAnswer, int id)
        {
            if (ModelState.IsValid)
            {
                scenarioAnswer.Number = 1;
                scenarioAnswer.Pid = id;
                db.Scenarios.Add(scenarioAnswer);
                db.WorkerIds.Find(id).Progress = Progress.Scenario2;
                db.SaveChanges();
                return RedirectToAction("Scenario2", new { id = id });
            }

            return View(scenarioAnswer);
        }

        public ActionResult Scenario2(int id)
        {
            var group = Functions.GetUserGroup(id);

            if (!group.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }

            switch (group)
            {
                case Group.Financial_High:
                    ViewBag.Question1 = Variables.Financial_High_Scenario_2;
                    break;
                case Group.Financial_Medium:
                    ViewBag.Question1 = Variables.Financial_Medium_Scenario_2;
                    break;
                case Group.Financial_Low:
                    ViewBag.Question1 = Variables.Financial_Low_Scenario_2;
                    break;
                case Group.Control_High:
                    ViewBag.Question1 = Variables.Control_High_Scenario_2;
                    break;
                case Group.Control_Medium:
                    ViewBag.Question1 = Variables.Control_Medium_Scenario_2;
                    break;
                case Group.Control_Low:
                    ViewBag.Question1 = Variables.Control_Low_Scenario_2;
                    break;
            }

            if (group.Value == Group.Financial_High || group.Value == Group.Financial_Medium || group.Value == Group.Financial_Low)
            {
                return View("Scenario2_Financial");
            }
            else
            {
                return View("Scenario2_Control");
            }
        }

        [HttpPost]
        public ActionResult Scenario2(Scenario scenarioAnswer, int id)
        {
            if (ModelState.IsValid)
            {
                scenarioAnswer.Number = 2;
                scenarioAnswer.Pid = id;
                db.Scenarios.Add(scenarioAnswer);
                db.WorkerIds.Find(id).Progress = Progress.Scenario3;
                db.SaveChanges();
                return RedirectToAction("Scenario3", new { id = id });
            }

            return View(scenarioAnswer);
        }

        public ActionResult Scenario3(int id)
        {
            var group = Functions.GetUserGroup(id);

            if (!group.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }

            switch (group)
            {
                case Group.Financial_High:
                    ViewBag.Question1 = Variables.Financial_High_Scenario_3a;
                    ViewBag.Question2 = Variables.Financial_High_Scenario_3b;
                    ViewBag.Question3 = Variables.Financial_High_Scenario_3c;
                    break;
                case Group.Financial_Medium:
                    ViewBag.Question1 = Variables.Financial_Medium_Scenario_3a;
                    ViewBag.Question2 = Variables.Financial_Medium_Scenario_3b;
                    ViewBag.Question3 = Variables.Financial_Medium_Scenario_3c;
                    break;
                case Group.Financial_Low:
                    ViewBag.Question1 = Variables.Financial_Low_Scenario_3a;
                    ViewBag.Question2 = Variables.Financial_Low_Scenario_3b;
                    ViewBag.Question3 = Variables.Financial_Low_Scenario_3c;
                    break;
                case Group.Control_High:
                    ViewBag.Question1 = Variables.Control_High_Scenario_3a;
                    ViewBag.Question2 = Variables.Control_High_Scenario_3b;
                    break;
                case Group.Control_Medium:
                    ViewBag.Question1 = Variables.Control_Medium_Scenario_3a;
                    ViewBag.Question2 = Variables.Control_Medium_Scenario_3b;
                    break;
                case Group.Control_Low:
                    ViewBag.Question1 = Variables.Control_Low_Scenario_3a;
                    ViewBag.Question2 = Variables.Control_Low_Scenario_3b;
                    break;
            }

            if (group.Value == Group.Financial_High || group.Value == Group.Financial_Medium || group.Value == Group.Financial_Low)
            {
                return View("Scenario3_Financial");
            }
            else
            {
                return View("Scenario3_Control");
            }
        }

        [HttpPost]
        public ActionResult Scenario3(Scenario scenarioAnswer, int id)
        {
            if (ModelState.IsValid)
            {
                scenarioAnswer.Number = 3;
                scenarioAnswer.Pid = id;
                db.Scenarios.Add(scenarioAnswer);
                db.WorkerIds.Find(id).Progress = Progress.Scenario4;
                db.SaveChanges();
                return RedirectToAction("Scenario4", new { id = id });
            }

            return View(scenarioAnswer);
        }

        public ActionResult Scenario4(int id)
        {
            var group = Functions.GetUserGroup(id);

            if (!group.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }

            switch (group)
            {
                case Group.Financial_High:
                    ViewBag.Question1 = Variables.Financial_High_Scenario_4a;
                    ViewBag.Question2 = Variables.Financial_High_Scenario_4b;
                    ViewBag.Question3 = Variables.Financial_High_Scenario_4c;
                    break;
                case Group.Financial_Medium:
                    ViewBag.Question1 = Variables.Financial_Medium_Scenario_4a;
                    ViewBag.Question2 = Variables.Financial_Medium_Scenario_4b;
                    ViewBag.Question3 = Variables.Financial_Medium_Scenario_4c;
                    break;
                case Group.Financial_Low:
                    ViewBag.Question1 = Variables.Financial_Low_Scenario_4a;
                    ViewBag.Question2 = Variables.Financial_Low_Scenario_4b;
                    ViewBag.Question3 = Variables.Financial_Low_Scenario_4c;
                    break;
                case Group.Control_High:
                    ViewBag.Question1 = Variables.Control_High_Scenario_4a;
                    ViewBag.Question2 = Variables.Control_High_Scenario_4b;
                    break;
                case Group.Control_Medium:
                    ViewBag.Question1 = Variables.Control_Medium_Scenario_4a;
                    ViewBag.Question2 = Variables.Control_Medium_Scenario_4b;
                    break;
                case Group.Control_Low:
                    ViewBag.Question1 = Variables.Control_Low_Scenario_4a;
                    ViewBag.Question2 = Variables.Control_Low_Scenario_4b;
                    break;
            }

            if (group.Value == Group.Financial_High || group.Value == Group.Financial_Medium || group.Value == Group.Financial_Low)
            {
                return View("Scenario4_Financial");
            }
            else
            {
                return View("Scenario4_Control");
            }
        }

        [HttpPost]
        public ActionResult Scenario4(Scenario scenarioAnswer, int id)
        {
            if (ModelState.IsValid)
            {
                scenarioAnswer.Number = 4;
                scenarioAnswer.Pid = id;
                db.Scenarios.Add(scenarioAnswer);
                db.WorkerIds.Find(id).Progress = Progress.ManipulationCheck;
                db.SaveChanges();
                return RedirectToAction("ManCheck", "Questions", new { id = id });
            }

            return View(scenarioAnswer);
        }
    }
}