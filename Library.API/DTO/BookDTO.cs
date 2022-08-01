namespace Library.API.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }
        public int Year { get; set; }

        public int InStock { get; set; }


    }
}
