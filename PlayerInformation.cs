namespace Spel_API
{
    public class PlayerInformation
    {
        public int playerId { get; set; }
        public string playerName { get; set; } = string.Empty;
        public int level { get; set; }
        public int experience { get; set; }
        public int coins { get; set; }
        public int ranking { get; set; } 
    }
}