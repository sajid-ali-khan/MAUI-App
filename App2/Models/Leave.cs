using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Leave
    {
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Leave(string leavetype, DateTime start, DateTime end)
        {
            this.LeaveType = leavetype;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}
