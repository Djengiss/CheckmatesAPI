namespace CheckmatesAPI.Models
{
    public class PlayerProfile
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public string username { get; set; }
        public int rating { get; set; }
        public bool isOnline { get; set; }
    }
}
