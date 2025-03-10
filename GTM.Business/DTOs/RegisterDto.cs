

namespace GTM.Business.DTOs
{
    public class RegisterDto
    {
        public string Username { get; set; } // Kullanıcı adı (unique)
        public string Password { get; set; } // Şifre (hashlenmiş)
        public string? Firstname { get; set; } // Ad
        public string? LastName { get; set; } // Soyad
        public string Email { get; set; } // Email adresi
    }
}