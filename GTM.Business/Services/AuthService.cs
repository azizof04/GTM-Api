using GTM.Business.DTOs;
using GTM.Core.Entities;
using GTM.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GTM.Business.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> RegisterAsync(string username, string email, string password, string firstName, string lastName)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(email);
            if (existingUser != null)
            {
                return "Bu email zaten kayıtlı!";
            }

            User newUser = new()
            {
                Username = username,
                Email = email,
                Firstname = firstName,
                LastName = lastName,
            };

            var result = await _userRepository.CreateUserAsync(newUser, password);

            if (!result.Succeeded)
            {
                return "Kullanıcı oluşturulurken hata oluştu!";
            }

            return "Kayıt başarılı!";
        }
    }
}
