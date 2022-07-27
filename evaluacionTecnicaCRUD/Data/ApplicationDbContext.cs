using evaluacionTecnicaCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace evaluacionTecnicaCRUD
{
    //Archivo necesario para la creación de la base de datos, desde aqui el manejador de paquetes toma como referencia el modelo Books
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}
