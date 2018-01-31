using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class SequenceTaskResponse
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int TrialNumber { get; set; }

        public int ResponseTime { get; set; }

        public int Response { get; set; }
    }

    public class PracticeSequenceTaskResponse
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int TrialNumber { get; set; }

        public int ResponseTime { get; set; }

        public int Response { get; set; }
    }
}