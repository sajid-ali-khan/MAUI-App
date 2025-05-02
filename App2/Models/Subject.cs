using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Strength { get; set; }

        public Subject(string subjectName, int strength)
        {
            this.SubjectName = subjectName;
            this.Strength = strength;
        }

    }
}
