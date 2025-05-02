using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public Student(string id, string name, string imagePath)
        {
            this.Id = id;
            this.Name = name;
            this.ImagePath = imagePath;
        }

    }
}