using System;
using System.Collections.Generic;
using SoftUni.MVC.LearningSystem.Web.Models;

namespace SoftUni.MVC.LearningSystem.Models.EntityModels
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ApplicationUser Trainger { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}