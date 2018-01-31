using Numerical_Stroop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numerical_Stroop.Controllers
{
    public class QuestionsController : Controller
    {
        public DB db = new DB();

        // GET: Questions
        public ActionResult Mancheck(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mancheck(ManipulationCheck answer, int id)
        {
            if (ModelState.IsValid)
            {
                answer.Pid = id;
                db.ManipulationChecks.Add(answer);
                db.WorkerIds.Find(id).Progress = Progress.StroopTask;
                db.SaveChanges();

                return RedirectToAction("Counting", "Task", new { id = id });
            }

            return View(answer);
        }


        public ActionResult FollowUp(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult FollowUp(int id, FollowUpQuestions followUpQuestions)
        {
            if (ModelState.IsValid)
            {
                followUpQuestions.Pid = id;
                db.FollowUpQuestions.Add(followUpQuestions);
                db.WorkerIds.Find(id).Progress = Progress.Questionnaire;
                db.SaveChanges();

                return RedirectToAction("Questionnaire1", new { id = id });
            }

            return View(followUpQuestions);
        }

        public ActionResult Questionnaire1(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questionnaire1(int id, QuestionnaireQuestionsViewModel1 questionnaireQuestions)
        {
            if (ModelState.IsValid)
            {
                var questions = new QuestionnaireQuestions()
                {
                    Pid = id,
                    Question1 = questionnaireQuestions.Question1,
                    Question2 = questionnaireQuestions.Question2,
                    Question3 = questionnaireQuestions.Question3,
                    Question4 = questionnaireQuestions.Question4,
                    Question5 = questionnaireQuestions.Question5,
                    Question6 = questionnaireQuestions.Question6,
                    Question7 = questionnaireQuestions.Question7,
                    Question8 = questionnaireQuestions.Question8
                };
                db.QuestionnaireQuestions.Add(questions);
                db.SaveChanges();

                return RedirectToAction("Questionnaire2", new { id = id });
            }

            return View(questionnaireQuestions);
        }

        public ActionResult Questionnaire2(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questionnaire2(int id, QuestionnaireQuestionsViewModel2 questionnaireQuestions)
        {
            if (ModelState.IsValid)
            {
                var questions = db.QuestionnaireQuestions.SingleOrDefault(m => m.Pid == id);

                if (questions == null)
                {
                    return View(questionnaireQuestions);
                }

                questions.Question9 = questionnaireQuestions.Question9;
                questions.Question10 = questionnaireQuestions.Question10;
                questions.Question11 = questionnaireQuestions.Question11;
                questions.Question12 = questionnaireQuestions.Question12;
                questions.Question13 = questionnaireQuestions.Question13;
                questions.Question14 = questionnaireQuestions.Question14;
                questions.Question15 = questionnaireQuestions.Question15;
                questions.Question16 = questionnaireQuestions.Question16;
                questions.Question17 = questionnaireQuestions.Question17;
                questions.Question18 = questionnaireQuestions.Question18;
                questions.Question19 = questionnaireQuestions.Question19;
                questions.Question20 = questionnaireQuestions.Question20;
                questions.Question21 = questionnaireQuestions.Question21;
                questions.Question22 = questionnaireQuestions.Question22;
                questions.Question23 = questionnaireQuestions.Question23;
                questions.Question24 = questionnaireQuestions.Question24;
                questions.Question25 = questionnaireQuestions.Question25;
                questions.Question26 = questionnaireQuestions.Question26;
                questions.Question27 = questionnaireQuestions.Question27;
                questions.Question28 = questionnaireQuestions.Question28;
                questions.Question29 = questionnaireQuestions.Question29;
                questions.Question30 = questionnaireQuestions.Question30;
                questions.Question31 = questionnaireQuestions.Question31;
                questions.Question32 = questionnaireQuestions.Question32;
                questions.Question33 = questionnaireQuestions.Question33;
                questions.Question34 = questionnaireQuestions.Question34;
                questions.Question35 = questionnaireQuestions.Question35;
                questions.Question36 = questionnaireQuestions.Question36;
                questions.Question37 = questionnaireQuestions.Question37;
                questions.Question38 = questionnaireQuestions.Question38;
                questions.Question39 = questionnaireQuestions.Question39;
                questions.Question40 = questionnaireQuestions.Question40;

                
                db.SaveChanges();

                return RedirectToAction("Questionnaire3", new { id = id });
            }

            return View(questionnaireQuestions);
        }

        public ActionResult Questionnaire3(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Questionnaire3(int id, QuestionnaireQuestionsViewModel3 questionnaireQuestions)
        {
            if (ModelState.IsValid)
            {
                var questions = db.QuestionnaireQuestions.SingleOrDefault(m => m.Pid == id);

                if (questions == null)
                {
                    return View(questionnaireQuestions);
                }

                questions.Question41 = questionnaireQuestions.Question41;
                questions.Question42 = questionnaireQuestions.Question42;
                questions.Question43 = questionnaireQuestions.Question43;
                questions.Question44 = questionnaireQuestions.Question44;
                questions.Question45 = questionnaireQuestions.Question45;
                questions.Question46 = questionnaireQuestions.Question46;
                questions.Question47 = questionnaireQuestions.Question47;
                questions.Question48 = questionnaireQuestions.Question48;
                questions.Question49 = questionnaireQuestions.Question49;
                questions.Question50 = questionnaireQuestions.Question50;
                questions.Question51 = questionnaireQuestions.Question51;
                questions.Question52 = questionnaireQuestions.Question52;
                questions.Question53 = questionnaireQuestions.Question53;
                questions.Question54 = questionnaireQuestions.Question54;
                questions.Question55 = questionnaireQuestions.Question55;
                questions.Question56 = questionnaireQuestions.Question56;
                questions.Question57 = questionnaireQuestions.Question57;
                questions.Question58 = questionnaireQuestions.Question58;
                questions.Question59 = questionnaireQuestions.Question59;
                questions.Question60 = questionnaireQuestions.Question60;


                db.WorkerIds.Find(id).Progress = Progress.Demographic1;
                db.SaveChanges();

                return RedirectToAction("Demographics1", new { id = id });
            }

            return View(questionnaireQuestions);
        }

        public ActionResult Demographics1(int id)
        {
            ViewBag.AnsweringIn = new SelectList(new List<object>()
            {
                new { Name = "USD" },
                new { Name = "INR" }
            },
            "Name",
            "Name"
            );

            ViewBag.Income = new SelectList(new List<object>()
            {
                new { Name = "Salary" },
                new { Name = "Wages (i.e. paid hourly)" },
                new { Name = "Government assistance" },
                new { Name = "Other assistance (i.e. from family, charity, or other)" },
                new { Name = "Amazon Mechanical Turk" },
                new { Name = "Does not apply" }
            }, 
            "Name", 
            "Name"
            );

            ViewBag.Workhours = new SelectList(new List<object>()
            {
                new { Name = "Full time" },
                new { Name = "Part time" },
                new { Name = "Casual" },
                new { Name = "Not currently working" },
                new { Name = "Does not apply" }
            },
            "Name",
            "Name"
            );

            ViewBag.Housing = new SelectList(new List<object>()
            {
                new { Name = "Home owner" },
                new { Name = "Long term lease (longer than a year)" },
                new { Name = "Short term lease (less than a year)" },
                new { Name = "Boarding" },
                new { Name = "Short term accommodation (e.g. motel, hostel)" },
                new { Name = "Other" }
            },
            "Name",
            "Name"
            );
            
            ViewBag.Forgofood = new SelectList(new List<object>()
            {
                new { Name = "Always" },
                new { Name = "Almost always" },
                new { Name = "Sometimes" },
                new { Name = "Almost never" },
                new { Name = "Never" },
                new { Name = "Prefer not to say" }
            },
            "Name",
            "Name"
            );

            ViewBag.Health = new SelectList(new List<object>()
            {
                new { Name = "Yes" },
                new { Name = "No" },
                new { Name = "Prefer not to say" }
            },
            "Name",
            "Name"
            );



            return View();
        }

        [HttpPost]
        public ActionResult Demographics1(int id, DemographicsViewModel1 demographics)
        {
            if (!demographics.SavingsAccountPreferNotToSay && string.IsNullOrEmpty(demographics.SavingsAccount))
            {
                ModelState.AddModelError("SavingsAccount", "This question is required, click \"Prefer not to say\" if you don't want to disclose the amount");
            }

            if (!demographics.CheckingAccountPreferNotToSay && string.IsNullOrEmpty(demographics.CheckingAccount))
            {
                ModelState.AddModelError("CheckingAccount", "This question is required, click \"Prefer not to say\" if you don't want to disclose the amount");
            }

            if (!demographics.HousingSpendPreferNotToSay && string.IsNullOrEmpty(demographics.HousingSpend))
            {
                ModelState.AddModelError("HousingSpend", "This question is required, click \"Prefer not to say\" if you don't want to disclose the amount");
            }

            if (!demographics.FoodSpendPreferNotToSay && string.IsNullOrEmpty(demographics.FoodSpend))
            {
                ModelState.AddModelError("FoodSpend", "This question is required, click \"Prefer not to say\" if you don't want to disclose the amount");
            }

            if (!demographics.UtilitySpendPreferNotToSay && string.IsNullOrEmpty(demographics.UtilitySpend))
            {
                ModelState.AddModelError("UtilitySpend", "This question is required, click \"Prefer not to say\" if you don't want to disclose the amount");
            }

            if (ModelState.IsValid)
            {
                var _demographics = new Demographics() {
                    Pid = id,
                    AnsweringIn = demographics.AnsweringIn,
                    IncomeSource = demographics.IncomeSource,
                    Income = demographics.Income,
                    WorkHours = demographics.WorkHours,
                    Education = demographics.Education,
                    Housing = demographics.Housing,
                    HouseholdDebt = demographics.HouseholdDebt,
                    HouseholdAssets = demographics.HouseholdAssets,
                    ForgoFood = demographics.ForgoFood,
                    SavingsAccount = demographics.SavingsAccount,
                    CheckingAccount = demographics.CheckingAccount,
                    HousingSpend = demographics.HousingSpend,
                    FoodSpend = demographics.FoodSpend,
                    UtilitySpend = demographics.UtilitySpend,
                    HealthIssues = demographics.HealthIssues,
                    HealthCare = demographics.HealthCare
                };

                db.Demographics.Add(_demographics);
                db.WorkerIds.Find(id).Progress = Progress.Demographic1;
                db.SaveChanges();

                return RedirectToAction("Demographics2", new { id = id });
            }

            ViewBag.AnsweringIn = new SelectList(new List<object>()
            {
                new { Name = "USD" },
                new { Name = "INR" }
            },
            "Name",
            "Name"
            );

            ViewBag.Income = new SelectList(new List<object>()
            {
                new { Name = "Salary" },
                new { Name = "Wages (i.e. paid hourly)" },
                new { Name = "Government assistance" },
                new { Name = "Other assistance (i.e. from family, charity, or other)" },
                new { Name = "Amazon Mechanical Turk" },
                new { Name = "Does not apply" }
            },
            "Name",
            "Name"
            );

            ViewBag.Workhours = new SelectList(new List<object>()
            {
                new { Name = "Full time" },
                new { Name = "Part time" },
                new { Name = "Casual" },
                new { Name = "Not currently working" },
                new { Name = "Does not apply" }
            },
            "Name",
            "Name"
            );

            ViewBag.Housing = new SelectList(new List<object>()
            {
                new { Name = "Home owner" },
                new { Name = "Long term lease (longer than a year)" },
                new { Name = "Short term lease (less than a year)" },
                new { Name = "Boarding" },
                new { Name = "Short term accommodation (e.g. motel, hostel)" },
                new { Name = "Other" }
            },
            "Name",
            "Name"
            );

            ViewBag.Forgofood = new SelectList(new List<object>()
            {
                new { Name = "Always" },
                new { Name = "Almost always" },
                new { Name = "Sometimes" },
                new { Name = "Almost never" },
                new { Name = "Never" },
                new { Name = "Prefer not to say" }
            },
            "Name",
            "Name"
            );

            ViewBag.Health = new SelectList(new List<object>()
            {
                new { Name = "Yes" },
                new { Name = "No" },
                new { Name = "Prefer not to say" }
            },
            "Name",
            "Name"
            );

            return View(demographics);
        }

        public ActionResult Demographics2(int id)
        {
            ViewBag.Gender = new SelectList(new List<object>()
            {
                new { Name = "Male" },
                new { Name = "Female" },
                new { Name = "Other" }
            },
            "Name",
            "Name"
            );

            ViewBag.Household = new SelectList(new List<object>()
            {
                new { Name = "1" },
                new { Name = "2" },
                new { Name = "3" },
                new { Name = "4" },
                new { Name = "5+" }
            },
            "Name",
            "Name"
            );

            ViewBag.DependentsList = new SelectList(new List<object>()
            {
                new { Name = "0" },
                new { Name = "1" },
                new { Name = "2" },
                new { Name = "3" },
                new { Name = "4" },
                new { Name = "5+" }
            },
            "Name",
            "Name"
            );

            ViewBag.Location = new SelectList(new List<object>()
            {
                new { Name = "Home" },
                new { Name = "Work" },
                new { Name = "Library" },
                new { Name = "Internet cafe" },
                new { Name = "Public transport" },
                new { Name = "Other" }
            },
           "Name",
           "Name"
           );


            ViewBag.Interruptions = new SelectList(new List<object>()
            {
                new { Name = "No interruptions" },
                new { Name = "Some interruptions" },
                new { Name = "A lot of interruptions" }
            },
           "Name",
           "Name"
           );

            return View();
        }

        [HttpPost]
        public ActionResult Demographics2(int id, DemographicsViewModel2 demographics)
        {
            if (!demographics.BlackAfricanAmerican && 
                !demographics.EastAsian &&
                !demographics.Hispanic &&
                !demographics.MiddleEastern &&
                !demographics.NativeAmerican &&
                !demographics.SoutheastAsian &&
                !demographics.SouthAsian &&
                !demographics.Caucasian &&
                !demographics.Indian &&
                !demographics.WouldRatherNotSay &&
                !demographics.Other
                )
            {
                ModelState.AddModelError("Ethnicity", "Ethnicity is a required field");
            }
            else if (demographics.Indian && string.IsNullOrEmpty(demographics.IndianOther))
            {
                ModelState.AddModelError("Ethnicity", "Please enter the region of India");
            }
            else if (demographics.Other && string.IsNullOrEmpty(demographics.EthnicityOther))
            {
                ModelState.AddModelError("Ethnicity", "Please describe your ethnicity");
            }


            if (ModelState.IsValid)
            {
                string ethnicity = "";

                if (demographics.BlackAfricanAmerican) ethnicity += "Black/African American;";
                if (demographics.EastAsian) ethnicity += "East Asian;";
                if (demographics.Hispanic) ethnicity += "Hispanic;";
                if (demographics.MiddleEastern) ethnicity += "Middle Eastern;";
                if (demographics.NativeAmerican) ethnicity += "Native American;";
                if (demographics.SoutheastAsian) ethnicity += "Southeast Asian;";
                if (demographics.SouthAsian) ethnicity += "South Asian;";
                if (demographics.Caucasian) ethnicity += "Caucasian;";
                if (demographics.Indian) ethnicity += "Indian: " + demographics.IndianOther + ";";
                if (demographics.WouldRatherNotSay) ethnicity += "Would rather not say;";
                if (demographics.Other) ethnicity += "Other: " + demographics.EthnicityOther + ";";

                var demo = db.Demographics.SingleOrDefault(m => m.Pid == id);
                if (demo == null)
                {
                    return View(demographics);
                }

                demo.Gender = demographics.Gender;
                demo.DateOfBirth = demographics.DateOfBirth;
                demo.HouseholdSize = demographics.HouseholdSize;
                demo.Dependents = demographics.Dependents;
                demo.Ethnicity = ethnicity;
                demo.EthnicityOther = demographics.EthnicityOther;
                demo.Location = demographics.Location;
                demo.Interruptions = demographics.Interruptions;

                db.WorkerIds.Find(id).Progress = Progress.Debrief;
                db.SaveChanges();

                return RedirectToAction("Debrief", "Home", new { id = id });
            }

            ViewBag.Gender = new SelectList(new List<object>()
            {
                new { Name = "Male" },
                new { Name = "Female" },
                new { Name = "Other" }
            },
            "Name",
            "Name"
            );

            ViewBag.Household = new SelectList(new List<object>()
            {
                new { Name = "1" },
                new { Name = "2" },
                new { Name = "3" },
                new { Name = "4" },
                new { Name = "5+" }
            },
            "Name",
            "Name"
            );

            ViewBag.DependentsList = new SelectList(new List<object>()
            {
                new { Name = "0" },
                new { Name = "1" },
                new { Name = "2" },
                new { Name = "3" },
                new { Name = "4" },
                new { Name = "5+" }
            },
            "Name",
            "Name"
            );

            ViewBag.Location = new SelectList(new List<object>()
            {
                new { Name = "Home" },
                new { Name = "Work" },
                new { Name = "Library" },
                new { Name = "Internet cafe" },
                new { Name = "Public transport" },
                new { Name = "Other" }
            },
           "Name",
           "Name"
           );


            ViewBag.Interruptions = new SelectList(new List<object>()
            {
                new { Name = "No interruptions" },
                new { Name = "Some interruptions" },
                new { Name = "A lot of interruptions" }
            },
           "Name",
           "Name"
           );

            return View(demographics);
        }
    }
}