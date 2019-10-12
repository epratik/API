using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Infrastructure
{
    public class BookRepository
    {
        private LibraryContext context;
        public BookRepository(LibraryContext libraryContext)
        {
            context = libraryContext;
        }
    }
}
