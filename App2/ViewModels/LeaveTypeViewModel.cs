using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    public class LeaveTypeViewModel
    {
        public ObservableCollection<string> LeaveTypes { get; set; }

        public LeaveTypeViewModel()
        {
            LeaveTypes = new ObservableCollection<string>()
            {
                "Sick leave",
                "Personal leave",
                "Emergency leave",
                "Other"
            };
        }
    }
}
