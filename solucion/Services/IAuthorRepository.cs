using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solucion.Models;

namespace solucion.Services
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();
           
    }
}