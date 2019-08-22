using EmployeeCard;
using LeaveBalance;
using System.Collections.Generic;

namespace HRSystem.Models
{
    public class EmployeeProfileViewModel
    {
        public employeecard EmployeeCard { get; set; }
        public List<leavebalance> LeaveBalances { get; set; }
    }
}
