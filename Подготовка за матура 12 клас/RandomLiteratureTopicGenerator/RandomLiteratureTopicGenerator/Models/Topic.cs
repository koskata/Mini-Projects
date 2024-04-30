namespace RandomLiteratureTopicGenerator.Models
{
    public class Topic
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string Url { get; set; } = null!;
    }
}
