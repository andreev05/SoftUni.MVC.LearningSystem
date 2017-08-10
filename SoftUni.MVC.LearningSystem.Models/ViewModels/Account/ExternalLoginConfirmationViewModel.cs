using System.ComponentModel.DataAnnotations;

namespace SoftUni.MVC.LearningSystem.Web.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
