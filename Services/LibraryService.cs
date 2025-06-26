using GridPaginate.Infraestructure.Data;
using GridPaginate.Models;
using Microsoft.EntityFrameworkCore;

namespace GridPaginate.Services
{
    public class LibraryService
    {
        public void Intialize(IServiceProvider serviceProvider)
        {
            using( var context = new LibraryDBContext (serviceProvider.GetRequiredService<DbContextOptions<LibraryDBContext>>()))
            {
                if (context.Books.Any()) return;

                for (int i = 1; i <= 2000; i++)
                {
                    context.Books.Add(new BookModel
                    {
                        Title = $"Book Title {i}",
                        Author = $"Author {i}",
                        Category = i % 2 == 0 ? "Fiction" : "Non-Fiction",
                        PublishDate = DateTime.Now.AddDays(-i)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
