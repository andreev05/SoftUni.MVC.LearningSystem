using System.ComponentModel.DataAnnotations;

namespace SoftUni.MVC.LearningSystem.Web.Models
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
