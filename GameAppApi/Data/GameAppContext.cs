using Microsoft.EntityFrameworkCore;
using GameAppApi.Models;

namespace GameAppApi.Data
{
    public class GameAppContext : DbContext
    {
        public GameAppContext(DbContextOptions<GameAppContext> options) : base(options) { }
        public DbSet<GameCategory> GameCategory { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
   
