using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numerical_Stroop.Models
{
    public class Variables
    {
        public static string Financial_High_Scenario_1 = "15";
        public static string Financial_Medium_Scenario_1 = "10";
        public static string Financial_Low_Scenario_1 = "5";
        public static string Control_High_Scenario_1 = "15";
        public static string Control_Medium_Scenario_1 = "10";
        public static string Control_Low_Scenario_1 = "5";

        public static string Financial_High_Scenario_2 = "2,000USD/128,000INR";
        public static string Financial_Medium_Scenario_2 = "200/12,800INR";
        public static string Financial_Low_Scenario_2 = "20/1,280INR";
        public static string Control_High_Scenario_2 = "2,000";
        public static string Control_Medium_Scenario_2 = "200";
        public static string Control_Low_Scenario_2 = "20";

        public static string Financial_High_Scenario_3a = "1,500/96,000INR";
        public static string Financial_Medium_Scenario_3a = "150/9,600INR";
        public static string Financial_Low_Scenario_3a = "15/960INR";
        public static string Financial_High_Scenario_3b = "150/9,600INR";
        public static string Financial_Medium_Scenario_3b = "15/960INR";
        public static string Financial_Low_Scenario_3b = "1.50/96INR";
        public static string Financial_High_Scenario_3c = "1800/115,200INR";
        public static string Financial_Medium_Scenario_3c = "180/2,160INR";
        public static string Financial_Low_Scenario_3c = "18/216INR";


        public static string Control_High_Scenario_3a = "1,500";
        public static string Control_Medium_Scenario_3a = "150";
        public static string Control_Low_Scenario_3a = "15";
        public static string Control_High_Scenario_3b = "150";
        public static string Control_Medium_Scenario_3b = "15";
        public static string Control_Low_Scenario_3b = "2";


        public static string Financial_High_Scenario_4a = "999/64,000INR";
        public static string Financial_Medium_Scenario_4a = "229/14,700INR";
        public static string Financial_Low_Scenario_4a = "29/1,860INR";
        public static string Financial_High_Scenario_4b = "100/6,400INR";
        public static string Financial_Medium_Scenario_4b = "23/1,470INR";
        public static string Financial_Low_Scenario_4b = "3/190INR";
        public static string Financial_High_Scenario_4c = "1200/76,800INR";
        public static string Financial_Medium_Scenario_4c = "276/17,640INR";
        public static string Financial_Low_Scenario_4c = "35/2,280INR";

        public static string Control_High_Scenario_4a = "999";
        public static string Control_Medium_Scenario_4a = "229";
        public static string Control_Low_Scenario_4a = "29";
        public static string Control_High_Scenario_4b = "100";
        public static string Control_Medium_Scenario_4b = "23";
        public static string Control_Low_Scenario_4b = "3";


        public static string[] Practice_Counting_Numbers = new string[]
        {
            "3 3 3",
            "5 5 5 5",
            "3 3",
            "1"
        };

        public static string[] Counting_Numbers = new string[]
        {
            "55555",
            "33",
            "1",
            "444",
            "3333",
            "22",
            "33333",
            "4",
            "22",
            "333",
            "1",
            "55555",
            "4444",
            "22",
            "33",
            "44444",
            "444",
            "333",
            "2",
            "333",
            "2222",
            "444",
            "22",
            "555",
            "4444",
            "1",
            "44",
            "333",
            "1",
            "55",
            "222",
            "22",
            "333",
            "22",
            "4444",
            "1",
            "444",
            "55555",
            "333",
            "222",
            "11111",
            "4444",
            "22",
            "3",
            "333",
            "55",
            "2222",
            "1",
            "22",
            "4444",
            "55555",
            "333",
            "22",
            "444",
            "2",
            "11"
        };

        public static string[] Practice_Letters = new string[]
        {
            "C",
            "J",
            "E",
            "J"
        };


        public static string[] Letters = new string[]
        {
            "E",
            "B",
            "O",
            "B",
            "K",
            "O",
            "K",
            "R",
            "K",
            "R",
            "A",
            "R",
            "M",
            "W",
            "P",
            "W",
            "P",
            "W",
            "C",
            "P",
            "C",
            "E",
            "C",
            "E",
            "A",
            "D",
            "L",
            "Q",
            "L",
            "Q",
            "C",
            "D",
            "K",
            "D",
            "B",
            "D",
            "O",
            "T",
            "O",
            "T",
            "W",
            "S",
            "Z",
            "S",
            "Z",
            "U",
            "N",
            "U",
            "N",
            "E",
            "K",
            "E"
        };

        public static string[] SequenceTaskInstructions = new string[]
        {
            "This is practice 1. We do not know what came two screens before this so <b>press 1 or 0</b> to continue.",
            "This is practice 2. We do not know what came two screens before this so <b>press 1 or 0</b> to continue.",
            "This is practice 3. We know that this letter (E) does not match the letter two screens ago (C). <b>Press the \"0\" key on your keyboard for NO</b>.",
            "This is practice 4. We know that this letter (J) matches the letter two screens ago (J). <b>Press the \"1\" key on your keyboard for YES</b>."
        };

        public static IEnumerable<SelectListItem> AnimalsValues = new SelectList(new List<object>()
            {
                new { Id = "Cat", Name = "Cat" },
                new { Id = "Dog", Name = "Dog" },
                new { Id = "Bird", Name = "Bird" },
                new { Id = "Goat", Name = "Goat" },
                new { Id = "Fish", Name = "Fish" },
                new { Id = "Cow", Name = "Cow" },
                new { Id = "Snake", Name = "Snake" },
                new { Id = "Monkey", Name = "Monkey" }
            }, 
            "Id", "Name");


        public static IEnumerable<SelectListItem> ThingsValues = new SelectList(new List<object>()
            {
                new { Id = "Chair", Name = "Chair" },
                new { Id = "Table", Name = "Table" },
                new { Id = "Book", Name = "Book" },
                new { Id = "Lamp", Name = "Lamp" },
                new { Id = "Cup", Name = "Cup" },
                new { Id = "Phone", Name = "Phone" },
                new { Id = "Radio", Name = "Radio" },
                new { Id = "Pot", Name = "Pot" }
            },
            "Id", "Name");


        public static IEnumerable<SelectListItem> CountriesValues = new SelectList(new List<object>()
            {
                new { Id = "China", Name = "China" },
                new { Id = "England", Name = "England" },
                new { Id = "Australia", Name = "Australia" },
                new { Id = "Bangladesh", Name = "Bangladesh" },
                new { Id = "Spain", Name = "Spain" },
                new { Id = "Nepal", Name = "Nepal" },
                new { Id = "Egypt", Name = "Egypt" },
                new { Id = "Germany", Name = "Germany" }
            },
            "Id", "Name");

        public static string[] MemoryPracticeItems = new string[]
        {
            "Book",
            "Australia",
            "Radio",
            "Bangladesh"
        };

        public static string[][] MemoryTaskTrialCategories = new string[][]
        {
            new string[] { "Animals","Things" },
            new string[] { "Animals","Things","Countries" },
            new string[] { "Animals","Countries" },
            new string[] { "Animals","Things","Countries" },
            new string[] { "Animals","Things","Countries" },
            new string[] { "Things","Countries" },
            new string[] { "Animals","Things","Countries" },
            new string[] { "Animals","Things","Countries" },
            new string[] { "Animals","Things" },
            new string[] { "Animals","Things","Countries" }
        };


        public static string[][] MemoryTaskItems = new string[][]
        {
            new string[] { "cat", "book", "chair", "dog" },
            new string[] { "Australia", "Spain", "chair", "bird", "goat", "China", "pot", "cat", "table" },
            new string[] { "fish", "Bangladesh", "snake", "Spain", "England", "monkey", "cow", "Nepal", "goat", "dog", "Australia" },
            new string[] { "cup", "Egypt", "cow", "cat", "Bangladesh", "fish", "book", "chair", "China", "Germany", "lamp", "bird", "England", "table" },
            new string[] { "Germany", "radio", "Nepal", "snake", "chair", "monkey" },
            new string[] { "China", "phone", "Australia", "lamp", "cup", "Bangladesh" },
            new string[] { "Germany", "Egypt", "monkey", "book", "Nepal", "snake", "chair", "Spain", "cow", "fish", "pot", "table" },
            new string[] { "Spain", "pot", "fish", "Bangladesh", "Australia", "goat", "lamp", "radio", "bird" },
            new string[] { "monkey", "chair", "phone", "bird", "cat", "table", "snake", "book", "dog", "lamp" },
            new string[] { "Spain", "book", "fish", "bird", "Egypt", "chair" },
        };
    }
}