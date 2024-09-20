
using Microsoft.EntityFrameworkCore;
using WebAPIProducto.Models;

namespace WebAPIProducto.Data
{
    public class dataContext: DbContext
    {
        public dataContext(DbContextOptions<dataContext> options)
        : base (options)
        {

        }

        public DbSet<Producto> productos {get;set;}
        
    }
}