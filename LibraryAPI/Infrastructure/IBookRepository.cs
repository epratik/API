using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Core.Domain;
using LibraryAPI.Core.Interfaces;

namespace LibraryAPI.Infrastructure
{
    public interface IBookRepository 
    {
        void AddBook(Book addbook);

    }
}
