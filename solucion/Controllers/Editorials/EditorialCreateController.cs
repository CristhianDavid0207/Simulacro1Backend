using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using solucion.Models;
using solucion.Services;

namespace solucion.Controllers.Editorials
{
    public class EditorialCreateController : ControllerBase
    {
        private readonly IEditorialRepository _editorialRepository;
        public EditorialCreateController(IEditorialRepository editorialRepository)
        {
            _editorialRepository = editorialRepository;
        }
        
    }
}