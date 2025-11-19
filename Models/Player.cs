namespace Balanced_Soccer_Team_Generator.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int BallControl { get; set; }
        public int PassingAccuracy { get; set; }
        public int Dribbling { get; set; }
        public int DefensiveAwareness { get; set; }
        public int Shooting { get; set; }

        public int OverallScore { get; set; }
        public int Rank { get; set; }
    }
}
