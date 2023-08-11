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
    public class AlkatreszeksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlkatreszeksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alkatreszeks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alkatreszek.ToListAsync());
        }

        // GET: Alkatreszeks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alkatreszek = await _context.Alkatreszek
                .FirstOrDefaultAsync(m => m.AlkatreszekId == id);
            if (alkatreszek == null)
            {
                return NotFound();
            }

            return View(alkatreszek);
        }

        // GET: Alkatreszeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alkatreszeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlkatreszekId,Megnevezes,SulyGr,Ar")] Alkatreszek alkatreszek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alkatreszek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alkatreszek);
        }

        // GET: Alkatreszeks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alkatreszek = await _context.Alkatreszek.FindAsync(id);
            if (alkatreszek == null)
            {
                return NotFound();
            }
            return View(alkatreszek);
        }

        // POST: Alkatreszeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlkatreszekId,Megnevezes,SulyGr,Ar")] Alkatreszek alkatreszek)
        {
            if (id != alkatreszek.AlkatreszekId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alkatreszek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlkatreszekExists(alkatreszek.AlkatreszekId))
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
            return View(alkatreszek);
        }

        // GET: Alkatreszeks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alkatreszek = await _context.Alkatreszek
                .FirstOrDefaultAsync(m => m.AlkatreszekId == id);
            if (alkatreszek == null)
            {
                return NotFound();
            }

            return View(alkatreszek);
        }

        // POST: Alkatreszeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alkatreszek = await _context.Alkatreszek.FindAsync(id);
            _context.Alkatreszek.Remove(alkatreszek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlkatreszekExists(int id)
        {
            return _context.Alkatreszek.Any(e => e.AlkatreszekId == id);
        }
    }
}
