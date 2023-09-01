namespace QuoteWebApplication.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }

        public Quote()
        {

        }
        public Quote(int id, string author, string description)
        {
            Id = id;
            Author = author;
            Description = description;
        }
    }
}

