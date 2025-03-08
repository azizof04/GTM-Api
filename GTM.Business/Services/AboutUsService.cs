using GTM.Core.Entities;
using GTM.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GTM.Business.Services
{
    public class AboutUsService
    {
        private readonly AboutUsRepository _repository;

        public AboutUsService(AboutUsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AboutUs>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<AboutUs?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(AboutUs aboutUs)
        {
            await _repository.AddAsync(aboutUs);
        }

        public async Task UpdateAsync(AboutUs aboutUs)
        {
            await _repository.UpdateAsync(aboutUs);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
