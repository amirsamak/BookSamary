using booksamary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksamary.Data.Services
{
    public class BookService : IBookService
    {
        public void Add(Book newbook)
        {
            Data.Books.Add(newbook);
            
        }

        public void Delete(int id)
        {
            var book = Data.Books.FirstOrDefault(n => n.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return Data.Books.FirstOrDefault(n => n.Id == id);

        }

        public void UpdateBook(int id, Book newbook)
        {
            var Oldbook = Data.Books.FirstOrDefault(n => n.Id == id);
            if(Oldbook!=null)
            {
                Oldbook.Title = newbook.Title;
                Oldbook.Author = newbook.Author;
                Oldbook.Description = newbook.Description;
                Oldbook.Rate = newbook.Rate;
                Oldbook.DateStart = newbook.DateStart;
                Oldbook.DateRead = newbook.DateRead;
                Data.Books.Add(Oldbook);
            }
            
        }
    }
}
