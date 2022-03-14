using Microsoft.EntityFrameworkCore;

namespace Core_6_SPA_Angular.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<ArticleMatrix>? ArticleMatrices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
