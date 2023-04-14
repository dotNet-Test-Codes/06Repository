using _06Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace _06Repository.Data
{
    public class ArticleDBContext : DbContext
    {
        public ArticleDBContext(DbContextOptions<ArticleDBContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
