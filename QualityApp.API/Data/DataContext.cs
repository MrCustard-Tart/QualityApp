using Microsoft.EntityFrameworkCore;
using QualityApp.API.Models;

namespace QualityApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Project> Projects { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}