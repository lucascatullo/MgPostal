
using Microsoft.EntityFrameworkCore;



namespace MgPostal.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }


        public DbSet<Envio> Envios { get; set; }

    }
}