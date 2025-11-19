using Balanced_Soccer_Team_Generator.Models;

namespace Balanced_Soccer_Team_Generator.ViewModels
{
    
        public class TeamResultVM
        {
            public string TeamName { get; set; } = string.Empty;
            public List<Player> Players { get; set; } = new();
            public int TotalScore { get; set; }
        }
    }
