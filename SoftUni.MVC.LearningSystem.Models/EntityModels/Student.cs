using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni.MVC.LearningSystem.Web.Models;

namespace SoftUni.MVC.LearningSystem.Models.EntityModels
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        public virtual ApplicationUser User { get; set; }

        public int Id { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
