using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class NumericPostPracticeQuestion
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int Question1 { get; set; }

        public int Question2 { get; set; }

        public int Question3 { get; set; }
    }

    public class SequencePostPracticeQuestion
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int Question1 { get; set; }

        public int Question2 { get; set; }

        public int Question3 { get; set; }
    }
}