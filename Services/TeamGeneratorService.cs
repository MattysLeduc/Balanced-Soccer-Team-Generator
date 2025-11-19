using Balanced_Soccer_Team_Generator.Models;
using Balanced_Soccer_Team_Generator.ViewModels;

namespace Balanced_Soccer_Team_Generator.Services
{
    public class TeamGeneratorService : ITeamGeneratorService
    {
        public void ComputeOverallAndRank(List<Player> players)
        {
            // 1) Compute overall score = sum of 5 skills
            foreach (var p in players)
            {
                p.OverallScore = p.BallControl + p.PassingAccuracy + p.Dribbling +
                                 p.DefensiveAwareness + p.Shooting;
            }

            // 2) Compute ranks based on thresholds (you will explain this in your report)
            foreach (var p in players)
            {
                int score = p.OverallScore;

                if (score >= 45) p.Rank = 1;
                else if (score >= 35) p.Rank = 2;
                else if (score >= 25) p.Rank = 3;
                else if (score >= 15) p.Rank = 4;
                else p.Rank = 5;
            }
        }

        public List<TeamResultVM> CreateBalancedTeams(List<Player> players, int teamCount)
        {
            var teams = new List<TeamResultVM>();
            for (int i = 0; i < teamCount; i++)
            {
                teams.Add(new TeamResultVM
                {
                    TeamName = $"Team {i + 1}",
                    Players = new List<Player>()
                });
            }

            // Sort by overall score descending
            players = players.OrderByDescending(p => p.OverallScore).ToList();

            int index = 0;
            bool forward = true;

            foreach (var player in players)
            {
                teams[index].Players.Add(player);

                if (forward)
                {
                    if (index == teamCount - 1)
                    {
                        forward = false;
                        index--;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        forward = true;
                        index++;
                    }
                    else
                    {
                        index--;
                    }
                }
            }

            // Compute total score per team
            foreach (var team in teams)
            {
                team.TotalScore = team.Players.Sum(p => p.OverallScore);
            }

            return teams;
        }
    }
}
