using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using MeuHelp.Data;

namespace MeuHelp.Views
{
    public class SalesmansController : Controller
    {
        private readonly MeuHelpContext _context;

        public SalesmansController(MeuHelpContext context)
        {
            _context = context;
        }

        // GET: Salesmans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salesman.ToListAsync());
        }

        // GET: Salesmans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesman = await _context.Salesman
                .FirstOrDefaultAsync(m => m.SalesmanId == id);
            if (salesman == null)
            {
                return NotFound();
            }

            return View(salesman);
        }

        // GET: Salesmans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salesmans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vendedor")] Salesman salesman)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesman);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesman);
        }

        // GET: Salesmans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesman = await _context.Salesman.FindAsync(id);
            if (salesman == null)
            {
                return NotFound();
            }
            return View(salesman);
        }

        // POST: Salesmans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vendedor")] Salesman salesman)
        {
            if (id != salesman.SalesmanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesman);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesmanExists(salesman.SalesmanId))
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
            return View(salesman);
        }

        // GET: Salesmans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesman = await _context.Salesman
                .FirstOrDefaultAsync(m => m.SalesmanId == id);
            if (salesman == null)
            {
                return NotFound();
            }

            return View(salesman);
        }

        // POST: Salesmans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesman = await _context.Salesman.FindAsync(id);
            _context.Salesman.Remove(salesman);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesmanExists(int id)
        {
            return _context.Salesman.Any(e => e.SalesmanId == id);
        }
    }
}
