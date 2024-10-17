using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Operations_App.Models;


namespace CRUD_Operations_App.Services
{
    public class BookService : IBookService
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DeleteBook(int id)
        {
            var book = GetBookById(id);


            books.Remove(book);
        }
        public void UpdateBook(Book updateBook)
        {
            var existingBook = GetBookById(updateBook.Id);
            if (existingBook != null)
            {
                existingBook.Title = updateBook.Title;
                existingBook.Author = updateBook.Author;
                existingBook.Description = updateBook.Description;
            }
            else
            {
                Console.WriteLine($"Book with id {updateBook.Id} not found!");
            }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
        public List<Book> GetBooks()
        {
            Console.WriteLine("returning books", books);
            return books;
        }
    }
}
