using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SoftUni.MVC.LearningSystem.Web.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}