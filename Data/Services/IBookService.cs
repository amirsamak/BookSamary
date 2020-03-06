using booksamary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksamary.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, Book newbook);
        void Delete(int id);
        void Add(Book newbook);
    }
}
