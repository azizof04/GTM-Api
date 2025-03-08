using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTM.Core.Entities
{
    [Table("Accounts")] // SQL'de tablo adı "Accounts" olacak
    public class Account
    {
        [Key]
        public int Id { get; set; } // MongoDB'deki `_id` yerine int ID

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
