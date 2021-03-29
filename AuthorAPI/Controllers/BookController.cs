using AuthorApi.Model;
using AuthorApi.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private BookDbContext ctx;

        public BookController()
        {
            this.ctx = new BookDbContext();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Book>>> GetBooks()
        {
            try
            {
                IList<Book> books = await ctx.Books.ToListAsync();
                return Ok(books);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddBook([FromBody] Book book)
        {
            try
            {
                ctx.Books.Add(book);
                await ctx.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [HttpDelete]
        [Route("{isbn:int}")]
        public async Task<ActionResult> DeleteBook([FromRoute] int isbn)
        {
            try
            {
                Book delete = ctx.Books.FirstOrDefault(b => b.ISBN == isbn);
                if(delete != null)
                {
                    ctx.Books.Remove(delete);
                    await ctx.SaveChangesAsync();
                }
                
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}
