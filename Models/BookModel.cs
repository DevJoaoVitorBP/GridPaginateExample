namespace GridPaginate.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public required string Title { get; set; } 
        public required string Author { get; set; } 
        public required string Category { get; set; }
        public required DateTime PublishDate { get; set; } = DateTime.Now;
    }
}
