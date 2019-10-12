using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LibraryAPI.Core.Domain
{
    public class Book
    {
        public string bookName { get; set; }
        public Guid Id { get; set; }
        public string userId { get; set; }

        public static Book AddBook(string name,string userId)
        {
            Book addBook = new Book();
            addBook.bookName = name;
            addBook.Id = Guid.NewGuid();
            addBook.userId = userId;

            return addBook;
        }
    }
    
}
