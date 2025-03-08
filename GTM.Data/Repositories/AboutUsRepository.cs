using GTM.Core.Data;
using GTM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GTM.Data.Repositories
{
    public class AboutUsRepository
    {
        private readonly ApplicationDbContext _context;

        public AboutUsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AboutUs>> GetAllAsync()
        {
            return await _context.AboutUs.ToListAsync();
        }

        public async Task<AboutUs?> GetByIdAsync(int id)
        {
            return await _context.AboutUs.FindAsync(id);
        }

        public async Task AddAsync(AboutUs aboutUs)
        {
            _context.AboutUs.Add(aboutUs);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AboutUs aboutUs)
        {
            _context.AboutUs.Update(aboutUs);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var aboutUs = await _context.AboutUs.FindAsync(id);
            if (aboutUs != null)
            {
                _context.AboutUs.Remove(aboutUs);
                await _context.SaveChangesAsync();
            }
        }
    }
}
