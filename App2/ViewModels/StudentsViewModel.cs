using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Models;

namespace App2.ViewModels
{
    public class StudentsViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>
            {
                new Student("101", "Aarav Sharma", "img101"),
                new Student("102", "Meera Reddy", "img102"),
                new Student("103", "Dhruv Patel", "img103"),
                new Student("104", "Ananya Verma", "img104"),
                new Student("105", "Kabir Nair", "img105"),
                new Student("106", "Sneha Iyer", "img106"),
                new Student("107", "Rohan Das", "img107"),
                new Student("108", "Priya Kulkarni", "img108"),
                new Student("109", "Arjun Bhatia", "img109"),
            };
        }
    }
}
