namespace SoftUni.MVC.LearningSystem.Data
{

    using Microsoft.AspNet.Identity.EntityFramework;
    using SoftUni.MVC.LearningSystem.Web.Models;

    public class LearningSystemContext : IdentityDbContext<ApplicationUser>
    {
        public LearningSystemContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static LearningSystemContext Create()
        {
            return new LearningSystemContext();
        }
    }
}