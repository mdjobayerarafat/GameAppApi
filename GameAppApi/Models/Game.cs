using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace GameAppApi.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Thumbnail { get; set; }
        public required string DownloadLink { get; set; }

        public int GameCategoryId { get; set; }
        public required GameCategory GameCategory { get; set; }

    }
}
