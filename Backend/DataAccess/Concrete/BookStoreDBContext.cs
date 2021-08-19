using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class BookStoreDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TUCAPO7\SQLEXPRESS;Database=BookStoreDB;User Id=sa;Password=Paf*13");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}