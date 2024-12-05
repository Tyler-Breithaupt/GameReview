using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameReview.Models;
using Microsoft.AspNetCore.Authorization;

namespace GameReview.Controllers
{
    [Authorize]
    public class ReviewersController : Controller
    {
        private readonly GameContext _context;

        public ReviewersController(GameContext context)
        {
            _context = context;
        }

        // GET: Reviewers
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
              return _context.Reviewers != null ? 
                          View(await _context.Reviewers.ToListAsync()) :
                          Problem("Entity set 'GameContext.Reviewers'  is null.");
        }

        // GET: Reviewers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reviewers == null)
            {
                return NotFound();
            }

            var reviewer = await _context.Reviewers
                .FirstOrDefaultAsync(m => m.ReviewerId == id);
            if (reviewer == null)
            {
                return NotFound();
            }

            return View(reviewer);
        }

        // GET: Reviewers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reviewers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewerId,Name,Email")] Reviewer reviewer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reviewer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reviewer);
        }

        // GET: Reviewers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reviewers == null)
            {
                return NotFound();
            }

            var reviewer = await _context.Reviewers.FindAsync(id);
            if (reviewer == null)
            {
                return NotFound();
            }
            return View(reviewer);
        }

        // POST: Reviewers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewerId,Name,Email")] Reviewer reviewer)
        {
            if (id != reviewer.ReviewerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reviewer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewerExists(reviewer.ReviewerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reviewer);
        }

        // GET: Reviewers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reviewers == null)
            {
                return NotFound();
            }

            var reviewer = await _context.Reviewers
                .FirstOrDefaultAsync(m => m.ReviewerId == id);
            if (reviewer == null)
            {
                return NotFound();
            }

            return View(reviewer);
        }

        // POST: Reviewers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reviewers == null)
            {
                return Problem("Entity set 'GameContext.Reviewers'  is null.");
            }
            var reviewer = await _context.Reviewers.FindAsync(id);
            if (reviewer != null)
            {
                _context.Reviewers.Remove(reviewer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewerExists(int id)
        {
          return (_context.Reviewers?.Any(e => e.ReviewerId == id)).GetValueOrDefault();
        }
    }
}
