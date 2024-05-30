using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.Data;

namespace solucion.Services
{
    public class EditorialRepository : IEditorialRepository
    {
        private readonly BaseContext _context;
        public EditorialRepository(BaseContext context)
        {
            _context = context;
        }
        
    }   
}