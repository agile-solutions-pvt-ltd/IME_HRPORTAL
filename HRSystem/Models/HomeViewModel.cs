using CalendarEvents;
using HrDashboard;
using System.Collections.Generic;

namespace HRSystem.Models
{
    public class HomeViewModel
    {
        public hrdashboard HrDashboard { get; set; }
        public List<calendarevents> CalendarEvents { get; set; }
    }
}
