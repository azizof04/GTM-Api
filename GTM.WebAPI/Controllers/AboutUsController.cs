using GTM.Business.Services;
using GTM.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GTM.Web.Controllers
{
    [ApiController]
    [Route("api/aboutus")]
    public class AboutUsController : ControllerBase
    {
        private readonly AboutUsService _service;

        public AboutUsController(AboutUsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<AboutUs>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AboutUs>> GetById(int id)
        {
            var aboutUs = await _service.GetByIdAsync(id);
            if (aboutUs == null)
                return NotFound(new { message = "Kayıt bulunamadı." });

            return Ok(aboutUs);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AboutUs aboutUs)
        {
            await _service.AddAsync(aboutUs);
            return CreatedAtAction(nameof(GetById), new { id = aboutUs.Id }, aboutUs);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AboutUs aboutUs)
        {
            var existing = await _service.GetByIdAsync(id);
            if (existing == null)
                return NotFound(new { message = "Kayıt bulunamadı." });

            existing.Title = aboutUs.Title;
            existing.Description = aboutUs.Description;

            await _service.UpdateAsync(existing);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _service.GetByIdAsync(id);
            if (existing == null)
                return NotFound(new { message = "Kayıt bulunamadı." });

            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
