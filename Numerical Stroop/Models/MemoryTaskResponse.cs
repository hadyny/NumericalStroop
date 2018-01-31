using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class MemoryTaskResponse
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int TrialNumber { get; set; }

        public string AnimalResponse { get; set; }

        public string ThingResponse { get; set; }

        public string CountryResponse { get; set; }
    }

    public class MemoryTaskPracticeResponse
    {
        public int Id { get; set; }

        public int Pid { get; set; }

        public int TrialNumber { get; set; }

        public string AnimalResponse { get; set; }

        public string ThingResponse { get; set; }

        public string CountryResponse { get; set; }
    }
}