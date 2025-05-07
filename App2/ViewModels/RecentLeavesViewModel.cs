using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Models;

namespace App2.ViewModels
{
    public class RecentLeavesViewModel
    {
        public ObservableCollection<Leave> RecentLeaves { get; set; }

        public RecentLeavesViewModel()
        {
            RecentLeaves = new ObservableCollection<Leave>()
            {
                new Leave("Sick Leave", new DateTime(2025, 5, 1), new DateTime(2025, 5, 3)),
                new Leave("Vacation", new DateTime(2025, 4, 20), new DateTime(2025, 4, 25)),
                new Leave("Casual Leave", new DateTime(2025, 4, 15), new DateTime(2025, 4, 16)),
                new Leave("Medical Leave", new DateTime(2025, 3, 28), new DateTime(2025, 3, 30)),
                new Leave("Emergency Leave", new DateTime(2025, 3, 10), new DateTime(2025, 3, 12))
            };
        }
    }
}
