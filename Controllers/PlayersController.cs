using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Balanced_Soccer_Team_Generator.Data;
using Balanced_Soccer_Team_Generator.Models;
using Balanced_Soccer_Team_Generator.Services;

namespace Balanced_Soccer_Team_Generator.Controllers
{
    public class PlayersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ITeamGeneratorService _teamService;

        public PlayersController(AppDbContext context, ITeamGeneratorService teamService)
        {
            _context = context;
            _teamService = teamService;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            var players = await _context.Players.ToListAsync();

            // Recompute scores/ranks in case you changed a player's skills
            _teamService.ComputeOverallAndRank(players);
            _context.UpdateRange(players);
            await _context.SaveChangesAsync();

            return View(players);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null) return NotFound();
            return View(player);
        }

        // POST: Players/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Player player)
        {
            if (id != player.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null) return NotFound();
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var p = await _context.Players.FindAsync(id);
            if (p != null)
            {
                _context.Players.Remove(p);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
