using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Final.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        //Escribir los modelos
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Distrito> Distritos{ get; set; }
       

    }
}
