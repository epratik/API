using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Core.Domain;
using LibraryAPI.Core.Interfaces;

namespace LibraryAPI.Infrastructure
{
    public class BookRepository :IBookRepository
    {
        private LibraryContext context;
        public BookRepository(LibraryContext libraryContext)
        {
            context = libraryContext;
        }
        public void AddBook(Book addbook)
        {
            context.Books.Add(addbook);

        }
    }
}
