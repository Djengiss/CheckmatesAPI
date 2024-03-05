using CheckmatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckmatesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{playerId}/PlayerName")]
        public string GetPlayerName(int playerId)
        {
            var player = new Player();
            player.name = "TEST: Player Name";
            return player.name;
        }

        [HttpGet]
        [Route("{playerId}/PlayerColor")]
        public string GetPlayerColor(int playerId)
        {
            var player = new Player();
            player.color = "TEST: Player Color";
            return player.color;
        }
    }
}
