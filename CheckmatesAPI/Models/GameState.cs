namespace CheckmatesAPI.Models
{
    public class GameState
    {
        public int Id { get; set; }
        // Game should probably implement an IGame interface, in case we do different game types
        public string gameState { get; set; } = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR"; // Starting setup in FEN notation

        // Both players should probably also be interfaces for the same reason
        Player whitePlayer {  get; set; }
        Player blackPlayer { get; set; }
        public int turnNumber { get; set; }
    }
}
