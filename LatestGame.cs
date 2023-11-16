namespace Spel_API
{
    public class LatestGame
    {
        public int gameId { get; set; }
        public DateTime timestamp { get; set; }
        public int score { get; set; }
        public int durationMinutes { get; set; }
        public string playerName { get; set; } = string.Empty;
        public int ranking { get; set; }
    }
}