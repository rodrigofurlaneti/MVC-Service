using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Services.Exceptions;
namespace MeuHelp.Views
{
    public class RepresentativesController : Controller
    {
        private readonly RepresentativeService _representativeService;
        public RepresentativesController(RepresentativeService representativeService)
        {
            _representativeService = representativeService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _representativeService.FindAllAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var representative = await _representativeService.FindByIdAsync(id.Value);
            if (representative == null)
            {
                return NotFound();
            }
            return View(representative);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Representative representative)
        {
            if (ModelState.IsValid)
            {
                await _representativeService.InsertAsync(representative);
                return RedirectToAction(nameof(Index));
            }
            return View(representative);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var representative = await _representativeService.FindByIdAsync(id.Value);
            if (representative == null)
            {
                return NotFound();
            }
            return View(representative);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Representative representative)
        {
            if (id != representative.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _representativeService.Update(representative);
                }
                catch (NotFoundException)
                {
                    return NotFound();
                }
                catch (DbConcurrencyException)
                {
                    return BadRequest();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(representative);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var representative = await _representativeService.FindByIdAsync(id.Value);
            if (representative == null)
            {
                return NotFound();
            }
            return View(representative);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _representativeService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
