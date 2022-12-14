using evaluacionTecnicaCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace evaluacionTecnicaCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Models.Books> listBooks = await _context.Books.ToListAsync();
                return Ok(listBooks);
            }
            catch (Exception ex )
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Books book)
        {
            try
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return Ok(book);
            }
            catch (Exception ex )
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Books book)
        {
            try
            {
                if (id != book.Id)
                    return NotFound();

                _context.Update(book);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Book Updated Successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var book = await _context.Books.FindAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return Ok(new {Message="Book Deleted Succesfully!"});
            }
            catch (Exception ex )
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
