using Microsoft.EntityFrameworkCore;
using MinimalAPIOracle.Models;

namespace MinimalAPIOracle.Config
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options ) : base( options )
        {
            //Database.EnsureCreated();
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
