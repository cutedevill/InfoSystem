using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryService.Models;

namespace DeliveryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly DeliveryContext _context;

        public DeliveryController(DeliveryContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Delivery>> GetDeliveryById(int id)
        {
            var delivery = await _context.Deliveries.FindAsync(id);

            if (delivery == null)
            {
                return NotFound();
            }

            return Ok(delivery);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delivery>>> GetAllDeliveries()
        {
            return Ok(await _context.Deliveries.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Delivery>> CreateDelivery(Delivery delivery)
        {
            delivery.DeliveryStatusChangeDate = DateTime.Now;
            _context.Deliveries.Add(delivery);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDeliveryById), new { id = delivery.DeliveryId }, delivery);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDelivery(int id, Delivery delivery)
        {
            if (id != delivery.DeliveryId)
            {
                return BadRequest();
            }

            _context.Entry(delivery).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            var delivery = await _context.Deliveries.FindAsync(id);

            if (delivery == null)
            {
                return NotFound();
            }

            _context.Deliveries.Remove(delivery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
