using GTM.Core.Data;
using GTM.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTM.Data.Repositories
{
    public class AccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Account?> GetByUsernameAsync(string username)
        {
            return await _context.Accounts.FirstOrDefaultAsync(a => a.Username == username);
        }

        public async Task CreateAsync(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
        }
    }
}
