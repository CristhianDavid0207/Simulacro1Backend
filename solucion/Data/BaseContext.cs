using Microsoft.EntityFrameworkCore;
using solucion.Models;

namespace solucion.Data
{
    public class BaseContext : DbContext
    {   
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }

        public DbSet<Author> authors {get; set;}
        public DbSet<Book> books {get; set;}
        public DbSet<Editorial> editorials {get; set;}
        
    }
}