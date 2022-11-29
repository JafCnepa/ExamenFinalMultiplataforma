using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Datos;
using Final.Models;

namespace Final.Controllers
{
    public class DistritoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DistritoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Distritoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Distritos.ToListAsync());
        }

        // GET: Distritoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Distritos == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos
                .FirstOrDefaultAsync(m => m.codigo_distrito == id);
            if (distrito == null)
            {
                return NotFound();
            }

            return View(distrito);
        }

        // GET: Distritoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Distritoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("codigo_distrito,nombre_distrito")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(distrito);
        }

        // GET: Distritoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Distritos == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos.FindAsync(id);
            if (distrito == null)
            {
                return NotFound();
            }
            return View(distrito);
        }

        // POST: Distritoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("codigo_distrito,nombre_distrito")] Distrito distrito)
        {
            if (id != distrito.codigo_distrito)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distrito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistritoExists(distrito.codigo_distrito))
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
            return View(distrito);
        }

        // GET: Distritoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Distritos == null)
            {
                return NotFound();
            }

            var distrito = await _context.Distritos
                .FirstOrDefaultAsync(m => m.codigo_distrito == id);
            if (distrito == null)
            {
                return NotFound();
            }

            return View(distrito);
        }

        // POST: Distritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Distritos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Distritos'  is null.");
            }
            var distrito = await _context.Distritos.FindAsync(id);
            if (distrito != null)
            {
                _context.Distritos.Remove(distrito);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistritoExists(int id)
        {
          return _context.Distritos.Any(e => e.codigo_distrito == id);
        }
    }
}
