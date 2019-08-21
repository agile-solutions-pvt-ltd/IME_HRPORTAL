using PostedSalaryAdvance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRSystem.Models
{
    public class PostedSalaryAdvanceViewModel
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
        public decimal Claimed_Amount { get; set; }

        public bool Claimed_AmountSpecified { get; set; }

        [Display(Name = "Approved Amount")]
        [Range(1, double.MaxValue, ErrorMessage = "The field Approved Amount must be greater than or equal to 1.")]
        public decimal Approved_Amount { get; set; }

        public bool Approved_AmountSpecified { get; set; }

        [Display(Name = "No Of Months")]
        [Range(1, int.MaxValue, ErrorMessage = "The field No Of Months must be greater than or equal to 1.")]
        public int No_of_Months { get; set; }

        public bool No_of_MonthsSpecified { get; set; }

        [Display(Name = "Fixed Deduction In Salary")]
        [Range(1, double.MaxValue, ErrorMessage = "The field Fixed Deduction In Salary must be greater than or equal to 1.")]
        public decimal Fixed_Deduction_in_Salary { get; set; }

        public bool Fixed_Deduction_in_SalarySpecified { get; set; }
        public DateTime Requested_Date { get; set; }
        public bool Requested_DateSpecified { get; set; }

        [Display(Name = "Reason For Advance")]
        public string Reason_For_Advance { get; set; }

        [Required]
        [Display(Name = "Reason For Rejection")]
        public string Reason_for_Rejection { get; set; }
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
        public bool Posted { get; set; }
        public bool PostedSpecified { get; set; }
        public string Posted_by { get; set; }
        public string Journal_Template_Name { get; set; }
        public string Journal_Batch_Name { get; set; }
        public Account_Type Account_Type { get; set; }
        public bool Account_TypeSpecified { get; set; }
        public string Account_No { get; set; }
        public bool Advance_Posted { get; set; }
        public bool Advance_PostedSpecified { get; set; }
        public DateTime Advance_Posted_Date { get; set; }
        public bool Advance_Posted_DateSpecified { get; set; }
        public string Advance_Posted_By { get; set; }
    }
}
