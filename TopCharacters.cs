namespace Spel_API
{
    public class TopCharacters
    {
        public string playerName { get; set; } = string.Empty;
        public int ranking { get; set; }
        public List<TopCharachtersInformation> topCharactersInformation { get; set; } = new List<TopCharachtersInformation>();
    }
}