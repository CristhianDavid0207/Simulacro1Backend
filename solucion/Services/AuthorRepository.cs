using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using solucion.Data;

namespace solucion.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BaseContext _context;
        public AuthorRepository(BaseContext context)
        {
            _context = context;
        }

    }
}