using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Numerical_Stroop.Models
{
    public class Demographics
    {
        public int Id { get; set; }

        public int Pid { get; set; }
        
        public string AnsweringIn { get; set; }

        public string IncomeSource { get; set; }

        public string Income { get; set; }
        
        public string WorkHours { get; set; }
        
        public string Education { get; set; }
        
        public string Housing { get; set; }
        
        public string HouseholdDebt { get; set; }
        
        public string HouseholdAssets { get; set; }
        
        public string ForgoFood { get; set; }
        
        public string SavingsAccount { get; set; }
        
        public string CheckingAccount { get; set; }
        
        public string HousingSpend { get; set; }
        
        public string FoodSpend { get; set; }
        
        public string UtilitySpend { get; set; }
        
        public string HealthIssues { get; set; }
        
        public string HealthCare { get; set; }

        
        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }
        
        public string HouseholdSize { get; set; }

        public string Dependents { get; set; }

        public string Ethnicity { get; set; }

        public string EthnicityOther { get; set; }

        public string IndianOther { get; set; }

        public string Location { get; set; }
        
        public string Interruptions { get; set; }

    }

    public class DemographicsViewModel1
    {
        [Required]
        public string AnsweringIn { get; set; }

        [Required]
        public string IncomeSource { get; set; }

        [Required]
        public string Income { get; set; }

        [Required]
        public string WorkHours { get; set; }

        [Required]
        public string Education { get; set; }

        [Required]
        public string Housing { get; set; }

        [Required]
        public string HouseholdDebt { get; set; }

        [Required]
        public string HouseholdAssets { get; set; }

        [Required]
        public string ForgoFood { get; set; }

        public string SavingsAccount { get; set; }
        public bool SavingsAccountPreferNotToSay { get; set; }
        
        public string CheckingAccount { get; set; }
        public bool CheckingAccountPreferNotToSay { get; set; }
        
        public string HousingSpend { get; set; }
        public bool HousingSpendPreferNotToSay { get; set; }
        
        public string FoodSpend { get; set; }
        public bool FoodSpendPreferNotToSay { get; set; }
        
        public string UtilitySpend { get; set; }
        public bool UtilitySpendPreferNotToSay { get; set; }

        [Required]
        public string HealthIssues { get; set; }

        [Required]
        public string HealthCare { get; set; }

    }

    
    public class DemographicsViewModel2
    {
        [Required]
        public string Gender { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string HouseholdSize { get; set; }

        [Required]
        public string Dependents { get; set; }

        public bool BlackAfricanAmerican { get; set; }

        public bool EastAsian { get; set; }

        public bool Hispanic { get; set; }

        public bool MiddleEastern { get; set; }

        public bool NativeAmerican { get; set; }

        public bool SoutheastAsian { get; set; }

        public bool SouthAsian { get; set; }

        public bool Caucasian { get; set; }

        public bool Indian { get; set; }

        public string IndianOther { get; set; }

        public bool WouldRatherNotSay { get; set; }

        public bool Other { get; set; }

        public string EthnicityOther { get; internal set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Interruptions { get; set; }
    }

}