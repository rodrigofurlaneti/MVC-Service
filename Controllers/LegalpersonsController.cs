using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Services;
using MeuHelp.Models.ViewModels;
using MeuHelp.Models;
using System.Collections.Generic;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Views
{
    public class LegalpersonsController : Controller
    {
        private readonly LegalpersonService _legalpersonService;
        private readonly TypeserviceService _typeserviceService;
        public LegalpersonsController(LegalpersonService legalpersonService, TypeserviceService typeserviceService)
        {
            _legalpersonService = legalpersonService;
            _typeserviceService = typeserviceService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _legalpersonService.FindAllAsync());
        }
        public async Task<IActionResult> Create()
        {
            var typeservices = await _typeserviceService.FindAllAsync();
            var viewModel = new LegalpersonFormViewModel { Typeservices = typeservices };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Legalperson legalperson)
        {
            await _legalpersonService.InsertAsync(legalperson);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var legalperson = await _legalpersonService.FindByIdAsync(id.Value);
            if (legalperson == null)
            {
                return NotFound();
            }
            return View(legalperson);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _legalpersonService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var legalperson = await _legalpersonService.FindByIdAsync(id.Value);
            if (legalperson == null)
            {
                return NotFound();
            }
            return View(legalperson);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var legalpersons = await _legalpersonService.FindByIdAsync(id.Value);
            if (legalpersons == null)
            {
                return NotFound();
            }
            List<Typeservice> typeservices = _typeserviceService.FindAll();
            LegalpersonFormViewModel viewModel = new LegalpersonFormViewModel
            {
                Legalperson = legalpersons,
                Typeservices = typeservices,
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Legalperson legalperson)
        {
            if (id != legalperson.Id)
            {
                return BadRequest();
            }
            try
            {
                await _legalpersonService.Update(legalperson);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }

        }
    }
}
