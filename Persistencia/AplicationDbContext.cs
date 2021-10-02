using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options){ 


        }
        private const string connectionString =@"Data Source=localhost\sqlexpress;Initial Catalog = MARKETCONTROLv1;Integrated Security = True";

        public DbSet <Cliente> clientes {get; set;}
        public DbSet <Proveedor> proveedores {get; set;}

        public DbSet <Empleado> empleados {get; set;}

        public DbSet <Directivo> directivos {get; set;}

        public DbSet <Inventario> inventarios {get; set;}

        public DbSet<Persona> personas{get; set;}

        public DbSet <Empresa> empresas {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){

                optionsBuilder.UseSqlServer(connectionString);

            

            }
            
        }
    }
}