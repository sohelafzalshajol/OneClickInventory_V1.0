using System.ComponentModel.DataAnnotations;

namespace OneClickInventory.Models
{
    public class CashBank
    {
        public int CashBankId { get; set; }
        [Display(Name = "Cash / Bank Name")]
        public string CashBankName { get; set; }
        public string Description { get; set; }
    }
}
