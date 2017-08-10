using System.ComponentModel.DataAnnotations;

namespace SoftUni.MVC.LearningSystem.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
