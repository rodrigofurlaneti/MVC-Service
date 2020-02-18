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
    public class SolicitationsController : Controller
    {
        private readonly MeuHelpContext _context;
        public SolicitationsController(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Solicitation.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var solicitation = await _context.Solicitation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitation == null)
            {
                return NotFound();
            }

            return View(solicitation);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Numbercard,Dateofbirth,Cpf,Andress,Service")] Solicitation solicitation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitation);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitation = await _context.Solicitation.FindAsync(id);
            if (solicitation == null)
            {
                return NotFound();
            }
            return View(solicitation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Numbercard,Dateofbirth,Cpf,Andress,Service")] Solicitation solicitation)
        {
            if (id != solicitation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitationExists(solicitation.Id))
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
            return View(solicitation);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitation = await _context.Solicitation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitation == null)
            {
                return NotFound();
            }

            return View(solicitation);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitation = await _context.Solicitation.FindAsync(id);
            _context.Solicitation.Remove(solicitation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SolicitationExists(int id)
        {
            return _context.Solicitation.Any(e => e.Id == id);
        }
    }
}
