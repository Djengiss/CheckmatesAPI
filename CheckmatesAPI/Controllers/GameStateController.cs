using CheckmatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckmatesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameStateController : ControllerBase
    {
        private readonly ILogger<GameStateController> _logger;

        public GameStateController(ILogger<GameStateController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGame")]
        public string Get()
        {
            var Newgame = new GameState();
            Newgame.gameState = "Successfully returned the game data";
            return Newgame.gameState;
        }
    }
}
