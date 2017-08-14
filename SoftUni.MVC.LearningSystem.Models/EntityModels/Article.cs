using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni.MVC.LearningSystem.Web.Models;

namespace SoftUni.MVC.LearningSystem.Models.EntityModels
{
    public class Article
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
