using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksamary.Data.Models;
using booksamary.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace booksamary.Controllers
{
    [Route("api/[Controller]")]
    public class BooksController : Controller
    {
        private IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            try
            {
                if(book.Author != null&& book.Title != null&& book.Description != null)
                {
                    _service.Add(book);
                    return Ok(book);
                }
                else
                {
                    return BadRequest("Book isnot added");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet("[Action]")]
        public IActionResult Get()
        {
            var allbooks = _service.GetAllBooks();
            return Ok(allbooks);
        }
       [HttpPut("UpdateBook/{id}")]
       public IActionResult UpdateBook(int id,[FromBody]Book book)
       {
            _service.UpdateBook(id, book);
            return Ok(book);
       }
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.Delete(id);
            return Ok();
        }
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book=_service.GetBookById(id);
            return Ok(book);
        }
    }
}