using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoachesSoccerCompanionWeb.Data;
using CoachesSoccerCompanionWeb.Models;

namespace CoachesSoccerCompanionWeb.Controllers
{
    public class PositionTimesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PositionTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PositionTimes
        public async Task<IActionResult> Index()
        {
              return _context.PositionTimes != null ? 
                          View(await _context.PositionTimes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PositionTimes'  is null.");
        }

        public ActionResult HandleButtonClick(string playtime)
        {
            return View("Index", playtime);
        }

        // GET: PositionTimes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.PositionTimes == null)
            {
                return NotFound();
            }

            var positionTime = await _context.PositionTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (positionTime == null)
            {
                return NotFound();
            }

            return View(positionTime);
        }

        // GET: PositionTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PositionTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlaytimeStart,PlaytimeEnd,Position,TimePlayed")] PositionTime positionTime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(positionTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(positionTime);
        }

        // GET: PositionTimes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.PositionTimes == null)
            {
                return NotFound();
            }

            var positionTime = await _context.PositionTimes.FindAsync(id);
            if (positionTime == null)
            {
                return NotFound();
            }
            return View(positionTime);
        }

        // POST: PositionTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, [Bind("Id,PlaytimeStart,PlaytimeEnd,Position,TimePlayed")] PositionTime positionTime)
        {
            if (id != positionTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(positionTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionTimeExists(positionTime.Id))
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
            return View(positionTime);
        }

        // GET: PositionTimes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.PositionTimes == null)
            {
                return NotFound();
            }

            var positionTime = await _context.PositionTimes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (positionTime == null)
            {
                return NotFound();
            }

            return View(positionTime);
        }

        // POST: PositionTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (_context.PositionTimes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PositionTimes'  is null.");
            }
            var positionTime = await _context.PositionTimes.FindAsync(id);
            if (positionTime != null)
            {
                _context.PositionTimes.Remove(positionTime);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionTimeExists(Guid? id)
        {
          return (_context.PositionTimes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
