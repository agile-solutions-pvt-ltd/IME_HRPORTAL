using LeaveRequestCard;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class LeaveRequestViewModel
    {
        public string Key { get; set; }

        public string Leave_Request_No { get; set; }

        [Required]
        [DisplayName("Employee No")]
        public string Employee_No { get; set; }

        [Required]
        [DisplayName("Full Name")]
        public string Full_Name { get; set; }

        [Required]
        [DisplayName("Leave Type Code")]
        public string Leave_Type_Code { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Leave Start Date")]
        public DateTime Leave_Start_Date { get; set; }

        public bool Leave_Start_DateSpecified { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Leave End Date")]
        public DateTime Leave_End_Date { get; set; }

        public bool Leave_End_DateSpecified { get; set; }

        [Required]
        [DisplayName("Leave Type")]
        [Range(1, int.MaxValue, ErrorMessage = "The Leave Type field is required.")]
        public Leave_Type Leave_Type { get; set; }

        public bool Leave_StatusSpecified { get; set; }

        [Required]
        [DisplayName("Substitute Employee No")]
        public string Substitute_Employee_No { get; set; }

        [DisplayName("Substitute Employee Name")]
        public string Substitute_Employee_Name { get; set; }

        [Required]
        public string Remarks { get; set; }
    }
}
