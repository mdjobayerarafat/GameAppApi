using Microsoft.EntityFrameworkCore;
using GameAppApi.Models;

namespace GameAppApi.Data
{
    public class GameAppContext : DbContext
    {
        public GameAppContext(DbContextOptions<GameAppContext> options) : base(options) { }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
   
