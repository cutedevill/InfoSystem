using Microsoft.AspNetCore.Mvc;
using CatalogService.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {

        private readonly CatalogContext _context;

        public BrandController(CatalogContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrandById(int id)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetAllBrands()
        {
            return Ok(await _context.Brands.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBrandById), new { id = brand.BrandId }, brand);
        }
    }
}