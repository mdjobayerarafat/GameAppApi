namespace GameAppApi.Models
{
    public class GameCategory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Thumbnail { get; set; }

        public List<Game> Games { get; set; } = new List<Game> ();
    }
}
