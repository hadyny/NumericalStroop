using Numerical_Stroop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numerical_Stroop.Controllers
{
    public class TaskController : Controller
    {
        public DB db = new DB();


        // Counting

        public ActionResult Counting(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ActionResult CountingTaskInstructions(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ActionResult CountingTaskPractice(int id)
        {
            var completed = db.CountingTaskPracticeResponses.Count(m => m.Pid == id);
            ViewBag.TaskNumbers = Variables.Practice_Counting_Numbers[completed];
            ViewBag.PracticeNumber = completed + 1;

            int hint = Variables.Practice_Counting_Numbers[completed].Replace(" ", "").Length;

            ViewBag.HintImageSrc = Url.Content("~/Content/keyboard-" + hint.ToString() + ".jpg");

            PracticeCountingTaskResponse model = new PracticeCountingTaskResponse()
            {
                Pid = id,
                Response = -1,
                ResponseTime = 0,
                TrialNumber = completed + 1
            };
            ViewBag.Pid = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult CountingTaskPractice(int id, PracticeCountingTaskResponse answer)
        {
            db.CountingTaskPracticeResponses.Add(answer);
            db.SaveChanges();

            if (db.CountingTaskPracticeResponses.Count(m => m.Pid == id) == Variables.Practice_Counting_Numbers.Length)
            {
                return RedirectToAction("CountingTaskPracticeCompleted", new { id = id });
            }
            else
            {
                return RedirectToAction("CountingTaskPractice", new { id = id });
            }
        }

        public ActionResult CountingTaskPracticeCompleted(int id)
        {
            var values = new List<object>()
            {
                new { Id = "1", Name = "1" },
                new { Id = "2", Name = "2" },
                new { Id = "3", Name = "3" },
                new { Id = "4", Name = "4" },
                new { Id = "5", Name = "5" }
            };

            IEnumerable<SelectListItem> selectValues = new SelectList(values, "Id", "Name");
            ViewBag.SelectValues = selectValues;

            return View();
        }

        [HttpPost]
        public ActionResult CountingTaskPracticeCompleted(int id, NumericPostPracticeQuestion answer)
        {
            if (ModelState.IsValid)
            {
                answer.Pid = id;
                db.PostCountingPracticeQuestions.Add(answer);
                db.SaveChanges();

                return RedirectToAction("CountingTask", new { id = id });
            }

            var values = new List<object>()
            {
                new { Id = "1", Name = "1" },
                new { Id = "2", Name = "2" },
                new { Id = "3", Name = "3" },
                new { Id = "4", Name = "4" },
                new { Id = "5", Name = "5" }
            };

            IEnumerable<SelectListItem> selectValues = new SelectList(values, "Id", "Name");
            ViewBag.SelectValues = selectValues;

            return View(answer);
        }

        public ActionResult CountingTask(int id)
        {
            var completed = db.CountingTaskResponses.Count(m => m.Pid == id);
            ViewBag.TaskNumbers = Variables.Counting_Numbers[completed];
            ViewBag.PracticeNumber = completed + 1;

            CountingTaskResponse model = new CountingTaskResponse()
            {
                Pid = id,
                Response = -1,
                ResponseTime = 0,
                TrialNumber = completed + 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CountingTask(int id, CountingTaskResponse countingTaskResponse)
        {
            db.CountingTaskResponses.Add(countingTaskResponse);
            db.SaveChanges();

            if (db.CountingTaskResponses.Count(m => m.Pid == id) == Variables.Counting_Numbers.Length)
            {
                return RedirectToAction("CountingTaskComplete", new { id = id });
            }
            else
            {
                return RedirectToAction("CountingTask", new { id = id });
            }
        }


        public ViewResult CountingTaskComplete(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        // Memory

        public ViewResult Memory(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ViewResult MemoryTaskInstructions(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ActionResult MemoryTaskPractice(int id)
        {
            var completed = db.MemoryTaskPracticeResponses.Count(m => m.Pid == id);
            ViewBag.Items = Variables.MemoryPracticeItems;
            ViewBag.Animals = Variables.AnimalsValues;
            ViewBag.Things = Variables.ThingsValues;
            ViewBag.Countries = Variables.CountriesValues;


            var model = new MemoryTaskPracticeResponse() {
                Pid = id,
                TrialNumber = completed + 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult MemoryTaskPractice(int id, MemoryTaskPracticeResponse answer)
        {
            db.MemoryTaskPracticeResponses.Add(answer);
            db.SaveChanges();
            
            return RedirectToAction("MemoryTaskPracticeComplete", new { id = id });
        }

        public ActionResult MemoryTaskPracticeComplete(int id)
        {
            ViewBag.Pid = id;
            return View();
        }


        public ActionResult MemoryTask(int id)
        {
            var completed = db.MemoryTaskResponses.Count(m => m.Pid == id);
            ViewBag.Items = Variables.MemoryTaskItems[completed];
            ViewBag.Animals = Variables.AnimalsValues;
            ViewBag.Things = Variables.ThingsValues;
            ViewBag.Countries = Variables.CountriesValues;

            if (Variables.MemoryTaskTrialCategories[completed].Contains("Animals"))
            {
                ViewBag.AnimalCategory = true;
            }
            if (Variables.MemoryTaskTrialCategories[completed].Contains("Things"))
            {
                ViewBag.ThingCategory = true;
            }
            if (Variables.MemoryTaskTrialCategories[completed].Contains("Countries"))
            {
                ViewBag.CountryCategory = true;
            }

            var model = new MemoryTaskResponse()
            {
                Pid = id,
                TrialNumber = completed + 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult MemoryTask(int id, MemoryTaskResponse memoryTaskResponse)
        {
            db.MemoryTaskResponses.Add(memoryTaskResponse);
            db.SaveChanges();

            if (db.MemoryTaskResponses.Count(m => m.Pid == id) == Variables.MemoryTaskItems.Length)
            {
                return RedirectToAction("MemoryTaskComplete", new { id = id });
            }
            else
            {
                return RedirectToAction("MemoryTask", new { id = id });
            }
        }

        public ActionResult MemoryTaskComplete(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        

        // Sequence


        public ViewResult Sequence(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ViewResult SequenceTaskInstructions(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ViewResult SequenceTaskExample(int id)
        {
            ViewBag.Pid = id;
            return View();
        }

        public ActionResult SequenceTaskPractice(int id)
        {
            var completed = db.SequenceTaskPracticeResponses.Count(m => m.Pid == id);
            ViewBag.TaskLetter = Variables.Practice_Letters[completed];
            ViewBag.PracticeNumber = completed + 1;
            
            ViewBag.Instructions = Variables.SequenceTaskInstructions[completed];

            PracticeSequenceTaskResponse model = new PracticeSequenceTaskResponse()
            {
                Pid = id,
                Response = -1,
                ResponseTime = 0,
                TrialNumber = completed + 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult SequenceTaskPractice(int id, PracticeSequenceTaskResponse answer)
        {
            db.SequenceTaskPracticeResponses.Add(answer);
            db.SaveChanges();

            if (db.SequenceTaskPracticeResponses.Count(m => m.Pid == id) == Variables.Practice_Letters.Length)
            {
                return RedirectToAction("SequenceTaskPracticeComplete", new { id = id });
            }
            else
            {
                return RedirectToAction("SequenceTaskPractice", new { id = id });
            }
        }

        public ActionResult SequenceTaskPracticeComplete(int id)
        {
            var values = new List<object>()
            {
                new { Id = "0", Name = "0" },
                new { Id = "1", Name = "1" }
            };

            IEnumerable<SelectListItem> selectValues = new SelectList(values, "Id", "Name");
            ViewBag.SelectValues = selectValues;

            return View();
        }

        [HttpPost]
        public ActionResult SequenceTaskPracticeComplete(int id, SequencePostPracticeQuestion answer)
        {
            if (ModelState.IsValid)
            {
                answer.Pid = id;
                db.PostSequencePracticeQuestions.Add(answer);
                db.SaveChanges();

                return RedirectToAction("SequenceTask", new { id = id });
            }

            var values = new List<object>()
            {
                new { Id = "0", Name = "0" },
                new { Id = "1", Name = "1" }
            };

            IEnumerable<SelectListItem> selectValues = new SelectList(values, "Id", "Name");
            ViewBag.SelectValues = selectValues;

            return View(answer);
        }

        public ActionResult SequenceTask(int id)
        {
            var completed = db.SequenceTaskResponses.Count(m => m.Pid == id);
            ViewBag.TaskLetter = Variables.Letters[completed];
            ViewBag.PracticeNumber = completed + 1;
            
            SequenceTaskResponse model = new SequenceTaskResponse()
            {
                Pid = id,
                Response = -1,
                ResponseTime = 0,
                TrialNumber = completed + 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult SequenceTask(int id, SequenceTaskResponse sequenceTaskResponse)
        {
            db.SequenceTaskResponses.Add(sequenceTaskResponse);
            db.SaveChanges();

            if (db.SequenceTaskResponses.Count(m => m.Pid == id) == Variables.Letters.Length)
            {
                return RedirectToAction("SequenceTaskComplete", new { id = id });
            }
            else
            {
                return RedirectToAction("SequenceTask", new { id = id });
            }
        }

        public ActionResult SequenceTaskComplete(int id)
        {
            ViewBag.Pid = id;
            return View();
        }
    }
}