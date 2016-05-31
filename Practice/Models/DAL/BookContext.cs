using System.Data.Entity;

namespace Practice.Models.DAL
{
    class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
