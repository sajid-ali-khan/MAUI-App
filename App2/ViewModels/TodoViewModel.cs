using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    public class TodoViewModel
    {
        public ObservableCollection<string> Todos { get; set; }

        public TodoViewModel()
        {
            Todos = new ObservableCollection<string>()
            {
                "Give an assignment for 3rd ECE",
                "Distribute exam papers for 2nd CSE",
                "Schedule a quiz for 2nd CSE"
            };
        }
    }
}
