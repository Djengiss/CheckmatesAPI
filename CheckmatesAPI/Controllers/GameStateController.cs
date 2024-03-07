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

        [HttpGet]
        [Route("GameId")]
        public int Get()
        {
            var game = new GameState();
            game.Id = 1;
            return game.Id;
        }

        [HttpGet]
        [Route("{gameId}/BoardState")]
        public string GetBoardstate(int gameId)
        {
            var Newgame = new GameState();
            return Newgame.gameState;
        }

        [HttpGet]
        [Route("{gameId}/TurnNumber")]
        public int GetTurnnumber(int gameId)
        {
            var game = new GameState(); // Should get the game where game.id matches 'gameId'
            game.turnNumber = 13;
            return game.turnNumber;
        }

        [HttpPut]
        [Route("{gameId}/MakeMove/{fenmove}")]
        public void PutMakeMove(int gameId, string fenmove)
        {
            // TODO: Update board to passed fen notation
        }

        [HttpPost]
        [Route("NewGame")]
        public void PostNewGame()
        {
            // TODO: Create new game
        }
    }
}
