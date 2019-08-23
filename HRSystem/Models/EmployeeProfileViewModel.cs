using EmployeeCard;
using LeaveBalance;
using System.Collections.Generic;

namespace HRSystem.Models
{
    public class EmployeeProfileViewModel
    {
        private string EmployeeImageField { get; set; }
        public string EmployeeImage
        {
            get {
                return this.EmployeeImageField;
            }
            set {
                this.EmployeeImageField = "data:image/jpg;base64," + value; 
            }
        }
        public employeecard EmployeeCard { get; set; }
        public List<leavebalance> LeaveBalances { get; set; }
    }
}
