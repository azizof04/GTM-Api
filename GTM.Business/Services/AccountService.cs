using GTM.Core.Entities;
using GTM.Data.Repositories;

namespace GTM.Business.Services
{
    public class AccountService
    {
        private readonly AccountRepository _accountRepository;

        public AccountService(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<string?> RegisterAsync(string username, string password)
        {
            var existingUser = await _accountRepository.GetByUsernameAsync(username);
            if (existingUser != null)
                return "Bu kullanıcı adı zaten mevcut.";

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // Şifreyi hashle
            var newAccount = new Account
            {
                Username = username,
                Password = hashedPassword
            };

            await _accountRepository.CreateAsync(newAccount);
            return "Kayıt başarılı!";
        }
    }
}
