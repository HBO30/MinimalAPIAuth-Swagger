using Microsoft.EntityFrameworkCore;
using MinimalJwt.Models;

namespace MinimalJwt.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}