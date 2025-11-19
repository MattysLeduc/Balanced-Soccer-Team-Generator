namespace Balanced_Soccer_Team_Generator.ViewModels
{
    public class PlayerSelectionVM
    {
        public int PlayerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int OverallScore { get; set; }
        public bool IsPresent { get; set; }
    }
}
