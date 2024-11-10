using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameAppApi.Data;
using GameAppApi.Models;

namespace GameAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameCategoriesController : ControllerBase
    {
        private readonly GameAppContext _context;

        public GameCategoriesController(GameAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameCategory>>> GetGameCategories()
        {
            return await _context.GameCategories.Include(gc => gc.Games).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameCategory>> GetGameCategory(int id)
        {
            var gameCategory = await _context.GameCategories.Include(gc => gc.Games)
                .FirstOrDefaultAsync(gc => gc.Id == id);

            if (gameCategory == null)
            {
                return NotFound();
            }

            return gameCategory;
        }

        [HttpPost]
        public async Task<ActionResult<GameCategory>> PostGameCategory(GameCategory gameCategory)
        {
            _context.GameCategories.Add(gameCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameCategory", new { id = gameCategory.Id }, gameCategory);
        }
    }
}