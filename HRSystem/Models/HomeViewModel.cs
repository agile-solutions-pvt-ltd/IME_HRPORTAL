using CalendarEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRSystem.Models
{
    public class HomeViewModel
    {
        public List<CalendarEventViewModel> CalendarEvents { get; set; }
    }

    public class CalendarEventViewModel
    {
        public string Key { get; set; }
        public string Base_Calendar_Code { get; set; }
        public Recurring_System Recurring_System { get; set; }
        public bool Recurring_SystemSpecified { get; set; }
        public DateTime Date { get; set; }
        public bool DateSpecified { get; set; }
        public Day Day { get; set; }
        public bool DaySpecified { get; set; }
        public string Description { get; set; }
        public bool Nonworking { get; set; }
        public bool NonworkingSpecified { get; set; }
    }
}
