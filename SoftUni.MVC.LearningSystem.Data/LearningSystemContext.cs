namespace SoftUni.MVC.LearningSystem.Data
{

    using Microsoft.AspNet.Identity.EntityFramework;
    using SoftUni.MVC.LearningSystem.Web.Models;

    public class LearningSystemContext : IdentityDbContext<ApplicationUser>
    {
        public LearningSystemContext()
            : base("name=LearningSystemContext")
        {

        }
    }
}