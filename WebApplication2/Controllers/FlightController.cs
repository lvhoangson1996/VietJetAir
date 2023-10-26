using Microsoft.AspNetCore.Mvc;
using WebApplication2.DatabaseDbContext;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {

        private readonly FlightDbContext _context;

        public FlightController(FlightDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var flights = _context.Flights.ToList();
            return Ok(flights);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Flight Get(string id)
        {
            return _context.Flights.Find(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Flight model)
        {
            try
            {
                _context.Flights.Add(model);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, model);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
