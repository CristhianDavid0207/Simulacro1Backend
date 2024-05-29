using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solucion.Models;
using solucion.Services;

namespace solucion.Controllers.Authors
{
    public class AuthorCreateController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorCreateController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        
    }
}