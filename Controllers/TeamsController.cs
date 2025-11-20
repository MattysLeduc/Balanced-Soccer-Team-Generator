using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Balanced_Soccer_Team_Generator.Data;
using Balanced_Soccer_Team_Generator.Services;
using Balanced_Soccer_Team_Generator.ViewModels;

namespace Balanced_Soccer_Team_Generator.Controllers
{
    public class TeamsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ITeamGeneratorService _teamService;

        public TeamsController(AppDbContext context, ITeamGeneratorService teamService)
        {
            _context = context;
            _teamService = teamService;
        }

        // STEP 1: Select players & number of teams
        [HttpGet]
        public async Task<IActionResult> SelectPlayers()
        {
            var players = await _context.Players.ToListAsync();

            _teamService.ComputeOverallAndRank(players);
            _context.UpdateRange(players);
            await _context.SaveChangesAsync();

            var vm = new GenerateTeamsVM
            {
                NumberOfTeams = 2,
                Players = players.Select(p => new PlayerSelectionVM
                {
                    PlayerId = p.Id,
                    Name = p.Name,
                    OverallScore = p.OverallScore,
                    IsPresent = true
                }).ToList()
            };

            return View("SelectPlayers", vm);
        }

        // STEP 2: POST - Generate balanced teams
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SelectPlayers(GenerateTeamsVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var selectedIds = vm.Players
                .Where(p => p.IsPresent)
                .Select(p => p.PlayerId)
                .ToList();

            var players = await _context.Players
                .Where(p => selectedIds.Contains(p.Id))
                .ToListAsync();

            _teamService.ComputeOverallAndRank(players);

            var teams = _teamService.CreateBalancedTeams(players, vm.NumberOfTeams);

            // Show teams on the right side
            ViewBag.GeneratedTeams = teams;

            return View(vm);
        }
    }
}
