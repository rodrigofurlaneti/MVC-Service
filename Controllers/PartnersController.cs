using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Models.ViewModels;
using MeuHelp.Services.Exceptions;
namespace MeuHelp.Views
{
    public class PartnersController : Controller
    {
        private readonly PartnerService _partnerService;
        private readonly TypeserviceService _typeserviceService;
        public PartnersController(PartnerService partnerService, TypeserviceService typeserviceService)
        {
            _typeserviceService = typeserviceService;
            _partnerService = partnerService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _partnerService.FindAllAsync());
        }
        public async Task<IActionResult> Create()
        {
            var typeservice = await _typeserviceService.FindAllAsync();
            var viewModel = new PartnerFormViewModel
            {
                Typeservice = typeservice
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Partner partner)
        {
            await _partnerService.InsertAsync(partner);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Partner = await _partnerService.FindByIdAsync(id.Value);
            if (Partner == null)
            {
                return NotFound();
            }
            return View(Partner);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _partnerService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Partner = await _partnerService.FindByIdAsync(id.Value);
            if (Partner == null)
            {
                return NotFound();
            }
            return View(Partner);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var partner = await _partnerService.FindByIdAsync(id.Value);
            if (partner == null)
            {
                return NotFound();
            }
            List<Typeservice> typeservices = _typeserviceService.FindAll();
            PartnerFormViewModel viewModel = new PartnerFormViewModel
            {
                Partner = partner,
                Typeservice = typeservices
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Partner partner)
        {
            if (id != partner.Id)
            {
                return BadRequest();
            }
            try
            {
                await _partnerService.Update(partner);
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
