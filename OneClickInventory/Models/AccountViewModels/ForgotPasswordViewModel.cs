using System.ComponentModel.DataAnnotations;

namespace OneClickInventory.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
