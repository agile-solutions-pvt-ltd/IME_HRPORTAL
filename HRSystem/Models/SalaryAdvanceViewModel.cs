using SalaryAdvanceRequest;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class SalaryAdvanceViewModel
    {
        public string Key { get; set; }
        public string No { get; set; }

        [Display(Name = "Employee No")]
        public string Employee_No { get; set; }

        [Display(Name = "Employee Name")]
        public string Employee_Name { get; set; }

        public string Department { get; set; }
        public string Branch { get; set; }
        public string Job_Title { get; set; }

        [Display(Name = "Applicable Amount")]
        public decimal Applicable_Amount { get; set; }

        public bool Applicable_AmountSpecified { get; set; }

        [Display(Name = "Monthly Deduction")]
        public decimal Monthly_Deduction { get; set; }

        public bool Monthly_DeductionSpecified { get; set; }

        [Display(Name = "Claimed Amount")]
        [Range(1, double.MaxValue, ErrorMessage = "The field Claimed Amount must be greater than or equal to 1.")]
        public decimal Claimed_Amount { get; set; }

        public bool Claimed_AmountSpecified { get; set; }
        public decimal Approved_Amount { get; set; }
        public bool Approved_AmountSpecified { get; set; }

        [Required]
        [Display(Name = "Reason For Advance")]
        public string Reason_For_Advance { get; set; }

        public Status Status { get; set; }
        public bool StatusSpecified { get; set; }
        public string Recommender_Code { get; set; }
        public string Recommender_Name { get; set; }
        public string Approver_Code { get; set; }
        public string Approver_Name { get; set; }
        public string HR_Code { get; set; }
        public string HR_Name { get; set; }
        public DateTime Approved_Date { get; set; }
        public bool Approved_DateSpecified { get; set; }
    }
}
