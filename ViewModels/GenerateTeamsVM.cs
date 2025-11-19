using System.ComponentModel.DataAnnotations;

namespace Balanced_Soccer_Team_Generator.ViewModels
{
    public class GenerateTeamsVM
    {
        [Range(1, 20, ErrorMessage = "Number of teams must be between 1 and 20.")]
        public int NumberOfTeams { get; set; } = 2;

        public List<PlayerSelectionVM> Players { get; set; } = new();
    }
}
