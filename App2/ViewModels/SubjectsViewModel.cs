using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Models;

namespace App2.ViewModels
{
    public class SubjectsViewModel
    {
        public ObservableCollection<Subject> Subjects { get; set; }

        public SubjectsViewModel()
        {
            Subjects = new ObservableCollection<Subject>()
            {
                new Subject("Mathematics", 24),
                new Subject("Data Structures", 34),
                new Subject(".NET MAUI", 3),
                new Subject("Compiler Design", 70)
            };
        }
    }
}
