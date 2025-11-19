using Balanced_Soccer_Team_Generator.Models;
using Balanced_Soccer_Team_Generator.ViewModels;

namespace Balanced_Soccer_Team_Generator.Services
{
    public interface ITeamGeneratorService
    {
        void ComputeOverallAndRank(List<Player> players);
        List<TeamResultVM> CreateBalancedTeams(List<Player> players, int teamCount);
    }
}
