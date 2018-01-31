using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class WorkerId
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        public string IpAddress { get; set; }

        public Group Group { get; set; }

        public Progress Progress { get; set; }
    }

    public enum Progress
    {
        Consent,
        Scenario1,
        Scenario2,
        Scenario3,
        Scenario4,
        ManipulationCheck,
        StroopTask,
        SequenceTask,
        FollowUpQuestions,
        Questionnaire,
        Demographic1,
        Demographic2,
        Debrief
    }

    public enum Group
    {
        Financial_High,
        Financial_Medium,
        Financial_Low,
        Control_High,
        Control_Medium,
        Control_Low
    }
}
