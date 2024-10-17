using System;
using System.Collections.Generic;
using CRUD_Operations_App.Models;
using System.Linq;
using CRUD_Operations_App.Services;

namespace CRUD_Operations_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBookService bookService = new BookService();

            // Adding books
            bookService.AddBook(new Book { Id = 1, Author = "Someone famous", Title = "The world's number one book", Description = "This is the world's best book please read" });
            bookService.AddBook(new Book { Id = 2, Author = "Someone else that's also famous", Title = "Another good book", Description = "This is also one of the best books to read" });

            // Getting all books
            List<Book> books = bookService.GetAllBooks();
            Console.WriteLine("All books in the system:");
            foreach (Book book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Author: {book.Author}, Title: {book.Title}, Description: {book.Description}");
            }

            // Updating a book
            bookService.UpdateBook(new Book { Id = 1, Author = "Someone famous, that is not famous anymore :)", Title = "This book is not good anymore", Description = "Don't read this book" });
            Console.WriteLine("Updated book:");
            var updatedBook = bookService.GetBookById(1);
            Console.WriteLine($"ID: {updatedBook.Id}, Author: {updatedBook.Author}, Title: {updatedBook.Title}, Description: {updatedBook.Description}");

            // Deleting a book
            bookService.DeleteBook(1);
            Console.WriteLine("Deleting book with ID 1...");
            books = bookService.GetAllBooks(); // Refresh the list after deletion
            foreach (Book book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Author: {book.Author}, Title: {book.Title}, Description: {book.Description}");
            }

            // Getting a book by ID
            Console.WriteLine("Showing book called by ID:");
            var gettingBookById = bookService.GetBookById(2);
            if (gettingBookById != null)
            {
                Console.WriteLine($"Book with ID 2: ID: {gettingBookById.Id}, Author: {gettingBookById.Author}, Title: {gettingBookById.Title}, Description: {gettingBookById.Description}");
            }
            else
            {
                Console.WriteLine("Book with ID 2 not found.");
            }
        }
    }
}
