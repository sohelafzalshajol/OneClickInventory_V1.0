using System.ComponentModel.DataAnnotations;

namespace OneClickInventory.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
