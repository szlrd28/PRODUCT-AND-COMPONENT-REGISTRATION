using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Keszprojekt.Data;
using Keszprojekt.Models;

namespace Keszprojekt.Controllers
{
    public class TermekeksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TermekeksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Termekeks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Termekek.ToListAsync());
        }

        // GET: Termekeks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termekek = await _context.Termekek
                .FirstOrDefaultAsync(m => m.TermekekId == id);
            if (termekek == null)
            {
                return NotFound();
            }

            return View(termekek);
        }

        // GET: Termekeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Termekeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TermekekId,Megnevezes,SulyGr,Ar")] Termekek termekek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(termekek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termekek);
        }

        // GET: Termekeks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termekek = await _context.Termekek.FindAsync(id);
            if (termekek == null)
            {
                return NotFound();
            }
            return View(termekek);
        }

        // POST: Termekeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TermekekId,Megnevezes,SulyGr,Ar")] Termekek termekek)
        {
            if (id != termekek.TermekekId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(termekek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TermekekExists(termekek.TermekekId))
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
            return View(termekek);
        }

        // GET: Termekeks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termekek = await _context.Termekek
                .FirstOrDefaultAsync(m => m.TermekekId == id);
            if (termekek == null)
            {
                return NotFound();
            }

            return View(termekek);
        }

        // POST: Termekeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var termekek = await _context.Termekek.FindAsync(id);
            _context.Termekek.Remove(termekek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TermekekExists(int id)
        {
            return _context.Termekek.Any(e => e.TermekekId == id);
        }
    }
}
