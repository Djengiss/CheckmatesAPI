using CheckmatesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckmatesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerProfileController : ControllerBase
    {
        private readonly ILogger<PlayerProfileController> _logger;

        public PlayerProfileController(ILogger<PlayerProfileController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{playerId}/PlayerName")]
        public string GetPlayerName(int playerId)
        {
            var player = new PlayerProfile();
            player.playerName = "TEST: PlayerProfile playerName";
            return player.playerName;
        }

        [HttpGet]
        [Route("{playerId}/PlayerUsername")]
        public string GetPlayerUsername(int playerId)
        {
            var player = new PlayerProfile();
            player.username = "TEST: PlayerProfile Username";
            return player.username;
        }

        [HttpGet]
        [Route("{playerId}/PlayerRating")]
        public int GetPlayerRating(int playerId)
        {
            var player = new PlayerProfile();
            player.rating = 1337;
            return player.rating;
        }

        [HttpGet]
        [Route("{playerId}/PlayerOnline")]
        public bool GetPlayerOnline(int playerId)
        {
            var player = new PlayerProfile();
            player.isOnline = true;
            return player.isOnline;
        }
    }
}
