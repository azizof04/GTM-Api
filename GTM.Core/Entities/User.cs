using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTM.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Auto-increment primary key

        [Required]
        [StringLength(50)]
        public string Username { get; set; } // Kullanıcı adı (unique)

        [Required]
        [StringLength(100)]
        public string Password { get; set; } // Şifre (hashlenmiş)

        public string? Firstname { get; set; } // Ad
        public string? LastName { get; set; } // Soyad
        public string? Exam { get; set; } // Sınav
        public string? Direction { get; set; } // Alan
        public string? City { get; set; } // Şehir
        public string? FatherName { get; set; } // Baba Adı
        public string? Phone { get; set; } // Telefon
        public string? BirthDay { get; set; } // Doğum günü
        public string? BirthMonth { get; set; } // Doğum ayı
        public string? BirthYear { get; set; } // Doğum yılı

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } // Email adresi

        [Required]
        public string Role { get; set; } // Kullanıcı rolü (admin, user)
    }
}
