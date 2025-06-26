

using GridPaginate.Models;
using Microsoft.EntityFrameworkCore;

namespace GridPaginate.Infraestructure.Data
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }
    }
}
