using PostedLeaveRequestCard;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class PostedLeaveRequestViewModel
    {
        public string Key { get; set; }
        public string Leave_Request_No { get; set; }

        [Required]
        [Display(Name = "Employee No")]
        public string Employee_No { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string Full_Name { get; set; }

        [Required]
        [Display(Name = "Requested Date")]
        [DataType(DataType.Date)]
        public DateTime Requested_Date { get; set; }

        public bool Requested_DateSpecified { get; set; }
        public string Work_Shift_Code { get; set; }
        public string Work_Shift_Description { get; set; }

        [Required]
        [Display(Name = "Leave Type Code")]
        public string Leave_Type_Code { get; set; }

        [Required]
        [Display(Name = "Leave Description")]
        public string Leave_Description { get; set; }

        [Required]
        [Display(Name = "Leave Start Date")]
        [DataType(DataType.Date)]
        public DateTime Leave_Start_Date { get; set; }

        public bool Leave_Start_DateSpecified { get; set; }

        [Required]
        [Display(Name = "Leave End Date")]
        [DataType(DataType.Date)]
        public DateTime Leave_End_Date { get; set; }

        public bool Leave_End_DateSpecified { get; set; }
        public DateTime Leave_Start_Time { get; set; }
        public bool Leave_Start_TimeSpecified { get; set; }
        public DateTime Leave_End_Time { get; set; }
        public bool Leave_End_TimeSpecified { get; set; }
        public string Fiscal_Year { get; set; }

        [Required]
        public string Remarks { get; set; }

        [Required]
        [Display(Name = "Pay Type")]
        [Range(1, int.MaxValue, ErrorMessage = "The Pay Type field is required.")]
        public Pay_Type Pay_Type { get; set; }

        public bool Pay_TypeSpecified { get; set; }

        [Required]
        [Display(Name = "No Of Days")]
        public decimal No_of_Days { get; set; }

        public bool No_of_DaysSpecified { get; set; }
        public string Substitute_Employee_No { get; set; }
        public string Substitute_Employee_Name { get; set; }

        [Required]
        [Display(Name = "Rejection Remarks")]
        public string Rejection_Remarks { get; set; }

        public Leave_Status Leave_Status { get; set; }
        public bool Leave_StatusSpecified { get; set; }
        public string Recommender_Code { get; set; }
        public string Recommender_Name { get; set; }
        public string Approver_Code { get; set; }
        public string Approver_Name { get; set; }
        public string HR_Code { get; set; }
        public string HR_Name { get; set; }
    }
}
