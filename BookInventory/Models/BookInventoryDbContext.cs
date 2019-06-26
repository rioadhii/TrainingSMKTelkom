using Microsoft.EntityFrameworkCore;

namespace BookInventory.Models
{
    public class BookInventoryDbContext : DbContext
    {
        public BookInventoryDbContext(DbContextOptions<BookInventoryDbContext> options) : base(options)
        {
        }

        public DbSet<MsGenre> MsGenres { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}