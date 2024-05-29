using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solucion.Models;
using solucion.Services;

namespace solucion.Controllers.Books
{
    public class BookUpdateController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookUpdateController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
    }
}