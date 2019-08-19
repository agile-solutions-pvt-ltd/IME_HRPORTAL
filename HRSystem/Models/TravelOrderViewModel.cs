using System;
using System.ComponentModel.DataAnnotations;
using TravelOrderCard;

namespace HRSystem.Models
{
    public class TravelOrderViewModel
    {
        public string Key { get; set; }
        public string Travel_Order_No { get; set; }

        [Required]
        [Display(Name = "Travel Type")]
        [Range(1, int.MaxValue, ErrorMessage = "The Travel Type field is required.")]
        public Travel_Type Travel_Type { get; set; }

        public bool Travel_TypeSpecified { get; set; }

        [Display(Name = "Expenses Only")]
        public bool Expenses_Only { get; set; }

        public bool Expenses_OnlySpecified { get; set; }

        [Display(Name = "Travel Allowance Only")]
        public bool Travel_Allowance_Only { get; set; }

        public bool Travel_Allowance_OnlySpecified { get; set; }
        public bool Lodging_Allowance_Only { get; set; }
        public bool Lodging_Allowance_OnlySpecified { get; set; }
        public bool Fooding_Allowance_Only { get; set; }
        public bool Fooding_Allowance_OnlySpecified { get; set; }

        [Display(Name = "Daily Allowance Only")]
        public bool Daily_Allowance_Only { get; set; }

        public bool Daily_Allowance_OnlySpecified { get; set; }

        [Display(Name = "Departure Branch")]
        public string Departure_Branch { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Departure Date AD")]
        public DateTime Depature_Date_AD { get; set; }

        public bool Depature_Date_ADSpecified { get; set; }
        public string Depature_Date_BS { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Arrival Date AD")]
        public DateTime Arrival_Date_AD { get; set; }

        public bool Arrival_Date_ADSpecified { get; set; }
        public string Arrival_Date_BS { get; set; }
        public int No_of_Days { get; set; }
        public bool No_of_DaysSpecified { get; set; }

        [Required]
        [Display(Name = "Employee No")]
        public string Employee_No { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        public string Employee_Name { get; set; }

        public string Designation { get; set; }
        public string Department { get; set; }

        [Required]
        [Display(Name = "Travel Destination I")]
        public string Travel_Destination_I { get; set; }

        [Display(Name = "Travel Destination II")]
        public string Travel_Destination_II { get; set; }

        [Display(Name = "Travel Destination III")]
        public string Travel_Destination_III { get; set; }

        [Required]
        [Display(Name = "Reason For Travel")]
        [Range(1, int.MaxValue, ErrorMessage = "The Reason For Travel field is required.")]
        public Reason_for_Travel Reason_for_Travel { get; set; }

        public bool Reason_for_TravelSpecified { get; set; }

        [Required]
        public string Remarks { get; set; }

        [Required]
        [Display(Name = "Mode Of Transportation")]
        [Range(1, int.MaxValue, ErrorMessage = "The Mode Of Transportation field is required.")]
        public Mode_Of_Transportation Mode_Of_Transportation { get; set; }

        public bool Mode_Of_TransportationSpecified { get; set; }

        [Display(Name = "Mode Of Transportation Others")]
        public string Mode_Of_Transportation_Others { get; set; }

        [Required]
        [Display(Name = "Approved Type")]
        [Range(1, int.MaxValue, ErrorMessage = "The Approved Type field is required.")]
        public Approved_Type Approved_Type { get; set; }

        public bool Approved_TypeSpecified { get; set; }
        public string Order_No { get; set; }
        public DateTime Requested_Date { get; set; }
        public bool Requested_DateSpecified { get; set; }
        public string Requested_By { get; set; }
        public bool Extension { get; set; }
        public bool ExtensionSpecified { get; set; }
        public string Country { get; set; }

        [Display(Name = "Exchange Rate")]
        public decimal Exchange_Rate { get; set; }

        public bool Exchange_RateSpecified { get; set; }
        public decimal Claimed_Lodging { get; set; }
        public bool Claimed_LodgingSpecified { get; set; }
        public decimal Claimed_Fooding { get; set; }
        public bool Claimed_FoodingSpecified { get; set; }

        [Display(Name = "Claimed_TA")]
        public decimal Claimed_TA { get; set; }

        public bool Claimed_TASpecified { get; set; }

        [Display(Name = "Claimed DA")]
        public decimal Claimed_DA { get; set; }

        public bool Claimed_DASpecified { get; set; }

        [Display(Name = "Claimed TADA")]
        public decimal Claimed_TADA { get; set; }

        public bool Claimed_TADASpecified { get; set; }

        [Display(Name = "Claimed Local Transportation")]
        public decimal Claimed_Local_Transportation { get; set; }

        public bool Claimed_Local_TransportationSpecified { get; set; }

        [Display(Name = "Claimed Fuel")]
        public decimal Claimed_Fuel { get; set; }

        public bool Claimed_FuelSpecified { get; set; }

        [Display(Name = "Claimed Other Expenses")]
        public decimal Claimed_Other_Expenses { get; set; }

        public bool Claimed_Other_ExpensesSpecified { get; set; }

        [Display(Name = "Claimed Total")]
        public decimal Claimed_Total { get; set; }

        public bool Claimed_TotalSpecified { get; set; }
        public decimal Fooding_Allowance { get; set; }
        public bool Fooding_AllowanceSpecified { get; set; }
        public decimal Lodging_Allowance { get; set; }
        public bool Lodging_AllowanceSpecified { get; set; }
        public decimal Travel_Allowance { get; set; }
        public bool Travel_AllowanceSpecified { get; set; }
        public decimal Daily_Allowance { get; set; }
        public bool Daily_AllowanceSpecified { get; set; }
        public decimal TADA_Nrs { get; set; }
        public bool TADA_NrsSpecified { get; set; }
        public decimal Transportation_Ticket_Nrs { get; set; }
        public bool Transportation_Ticket_NrsSpecified { get; set; }
        public decimal Local_Transportation_Nrs { get; set; }
        public bool Local_Transportation_NrsSpecified { get; set; }
        public decimal Fuel_Nrs { get; set; }
        public bool Fuel_NrsSpecified { get; set; }
        public decimal Other_Expenses_Nrs { get; set; }
        public bool Other_Expenses_NrsSpecified { get; set; }
        public decimal Total_Nrs { get; set; }
        public bool Total_NrsSpecified { get; set; }

        [Display(Name = "Travel Status")]
        public Travel_Status Travel_Status { get; set; }

        public bool Travel_StatusSpecified { get; set; }
        public string Recommender_Code { get; set; }
        public string Recommender_Name { get; set; }
        public string Approver_Code { get; set; }
        public string Approver_Name { get; set; }
        public string HR_Code { get; set; }
        public string HR_Name { get; set; }
        public string Journal_Template_Name { get; set; }
        public string Journal_Batch_Name { get; set; }
        public Account_Type Account_Type { get; set; }
        public bool Account_TypeSpecified { get; set; }
        public string Account_No { get; set; }
        public TADA_Setup[] TADA_Setup { get; set; }
    }
}
