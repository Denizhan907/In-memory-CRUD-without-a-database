using CRUD_Operations_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations_App.Services
{
    public interface IBookService
    {
        void AddBook(Book book);
        void DeleteBook(int Id);
        Book GetBookById(int Id);
        void UpdateBook(Book book);
        List<Book> GetAllBooks();
    }
}
