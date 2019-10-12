using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Infrastructure;
using LibraryAPI.Core.DTO;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBookController : ControllerBase
    {
        IBookRepository _bookrepo;
        
        public AddBookController(IBookRepository bookRepo)
        {
            _bookrepo = bookRepo;
        }

        [HttpPost]
        [Route("api/Book/AddBook")]
        public ActionResult<string> AddBook(BookDTO bDto)
        {
           var book = LibraryAPI.Core.Domain.Book.AddBook(bDto.name,bDto.userId);

            return book.bookName;
        }
    }
}