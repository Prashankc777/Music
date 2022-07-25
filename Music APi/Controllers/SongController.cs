using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music_APi.Data;
using Music_APi.Models;

namespace Music_APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private ApiDbContext _dbContext;

        public SongController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            return Ok( await _dbContext.Songs.ToListAsync());
        }

        // GET api/<SongController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var song = await _dbContext.Songs.FindAsync(id); 
            return Ok(song);
        }

        // POST api/<SongController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song value)
        {
            await _dbContext.Songs.AddAsync(value);
           await _dbContext.SaveChangesAsync();
           return Ok();
        }

        // PUT api/<SongController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
