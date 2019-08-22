using PostedTravelVoucherCard;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRSystem.Models
{
    public class PostedTravelVoucherViewModel
    {
        public string Key { get; set; }

        [Display(Name = "Travel Order No")]
        public string Travel_Order_Form_No { get; set; }

        [Display(Name = "Employee No")]
        public string Travelrs_ID_No { get; set; }

        [Display(Name = "Employee Name")]
        public string Travelers_Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public decimal No_of_Days_Planned { get; set; }
        public bool No_of_Days_PlannedSpecified { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Actual Departure Date")]
        public DateTime Actual_Departure_Date_AD { get; set; }

        public bool Actual_Departure_Date_ADSpecified { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Actual Arrival Date")]
        public DateTime Actual_Arrival_Date_AD { get; set; }

        public bool Actual_Arrival_Date_ADSpecified { get; set; }
        public decimal No_of_Days_Actual { get; set; }
        public bool No_of_Days_ActualSpecified { get; set; }

        [Required]
        [Display(Name = "Fulfillment Of Purpose")]
        public string Fulfillment_of_Purpose { get; set; }

        public bool Posted { get; set; }
        public bool PostedSpecified { get; set; }
        public string Posted_By { get; set; }
        public DateTime Posted_Date { get; set; }
        public bool Posted_DateSpecified { get; set; }
        public DateTime Depature_Date_AD { get; set; }
        public bool Depature_Date_ADSpecified { get; set; }
        public DateTime Arrival_Date_AD { get; set; }
        public bool Arrival_Date_ADSpecified { get; set; }
        public Mode_Of_Transportation Mode_Of_Transportation { get; set; }
        public bool Mode_Of_TransportationSpecified { get; set; }
        public string Travel_Destination_I { get; set; }
        public string Travel_Destination_II { get; set; }
        public string Travel_Destination_III { get; set; }

        [Display(Name = "Travel Allowance")]
        public decimal Travel_Allowance_90Percent { get; set; }

        public bool Travel_Allowance_90PercentSpecified { get; set; }

        [Display(Name = "Daily Allowance")]
        public decimal Daily_Allowance_90Percent { get; set; }

        public bool Daily_Allowance_90PercentSpecified { get; set; }
        public decimal Local_Transportation { get; set; }
        public bool Local_TransportationSpecified { get; set; }
        public decimal Fuel_Expenses_Nrs { get; set; }
        public bool Fuel_Expenses_NrsSpecified { get; set; }
        public decimal Other_Expenses_Nrs { get; set; }
        public bool Other_Expenses_NrsSpecified { get; set; }
        public decimal Advance_Amount { get; set; }
        public bool Advance_AmountSpecified { get; set; }

        [Display(Name = "Travel Expenses")]
        public decimal Claimed_Travel_Expenses { get; set; }

        public bool Claimed_Travel_ExpensesSpecified { get; set; }

        [Display(Name = "Driver Allowance")]
        public decimal Claimed_Driver_Allowance { get; set; }

        public bool Claimed_Driver_AllowanceSpecified { get; set; }

        [Display(Name = "Fuel Expenses")]
        public decimal Claimed_Fuel_Expenses { get; set; }

        public bool Claimed_Fuel_ExpensesSpecified { get; set; }

        [Display(Name = "Guest Expenses")]
        public decimal Claimed_Guest_Expensesv { get; set; }

        public bool Claimed_Guest_ExpensesSpecified { get; set; }

        [Display(Name = "Total Amount")]
        public decimal Total_Claimed_Amount { get; set; }

        public bool Total_Claimed_AmountSpecified { get; set; }

        [Display(Name = "Travel Allowance")]
        public decimal Travel_Allowance_100Percent { get; set; }

        public bool Travel_Allowance_100PercentSpecified { get; set; }

        [Display(Name = "Daily Allowance")]
        public decimal Daily_Allowance_100Percent { get; set; }
        public bool Daily_Allowance_100PercentSpecified { get; set; }

        [Display(Name = "Travel Expenses")]
        public decimal Approved_Travel_Expenses { get; set; }

        public bool Approved_Travel_ExpensesSpecified { get; set; }

        [Display(Name = "Driver Allowance")]
        public decimal Approved_Driver_Allowance { get; set; }

        public bool Approved_Driver_AllowanceSpecified { get; set; }

        [Display(Name = "Fuel Expenses")]
        public decimal Approved_Fuel_Expenses { get; set; }

        public bool Approved_Fuel_ExpensesSpecified { get; set; }

        [Display(Name = "Guest Expenses")]
        public decimal Approved_Guest_Expenses { get; set; }

        public bool Approved_Guest_ExpensesSpecified { get; set; }

        [Display(Name = "Total Amount")]
        public decimal Total_Approved_Amount { get; set; }

        public bool Total_Approved_AmountSpecified { get; set; }
        public bool Settled { get; set; }
        public bool SettledSpecified { get; set; }
        public string Settled_By { get; set; }
        public DateTime Settled_Date { get; set; }
        public bool Settled_DateSpecified { get; set; }
        public Status Status { get; set; }
        public bool StatusSpecified { get; set; }
        public string Recommender_Code { get; set; }
        public string Recommender_Name { get; set; }
        public string Approver_Code { get; set; }
        public string Approver_Name { get; set; }
        public string HR_Code { get; set; }
        public string HR_Name { get; set; }
        public string Journal_Template_Name { get; set; }
        public string Journal_Batch_Name { get; set; }
    }
}
