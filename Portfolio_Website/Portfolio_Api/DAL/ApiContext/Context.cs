using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Portfolio_Api.DAL.Entity;

namespace Portfolio_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SEMIH\\SQLEXPRESS;database=DbPortfolioApi;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categorys { get; set; }
      
    }
}
