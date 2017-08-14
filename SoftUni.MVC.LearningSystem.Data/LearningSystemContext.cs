namespace SoftUni.MVC.LearningSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SoftUni.MVC.LearningSystem.Models.EntityModels;
    using SoftUni.MVC.LearningSystem.Web.Models;

    public class LearningSystemContext : IdentityDbContext<ApplicationUser>
    {
        //if you want to change the connection name you might have to do it as
        //: base("name=LearningSystem", throwIfV1Schema: false) since sometimes it takes it as connstring
        public LearningSystemContext()
            : base("LearningSystem", throwIfV1Schema: false) 
                                                                
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Article> Articles { get; set; }

        public static LearningSystemContext Create()
        {
            return new LearningSystemContext();
        }
    }
}