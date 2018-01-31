using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class Scenario
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int Number { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Answer { get; set; }
    }
}