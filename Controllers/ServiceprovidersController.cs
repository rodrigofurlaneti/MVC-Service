using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Models.ViewModels;
using System.Collections.Generic;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Views
{
    public class ServiceprovidersController : Controller
    {
        private readonly ServiceproviderService _serviceproviderService;
        private readonly TypeserviceService _typeserviceService;
        public ServiceprovidersController(ServiceproviderService serviceproviderService, TypeserviceService typeserviceService)
        {
            _serviceproviderService = serviceproviderService;
            _typeserviceService = typeserviceService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _serviceproviderService.FindAllAsync());
        }
        public async Task<IActionResult> Create()
        {
            var typeservices = await _typeserviceService.FindAllAsync();
            var viewModel = new ServiceproviderFormViewModel 
            { 
                Typeservices = typeservices
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Serviceprovider Serviceprovider)
        {
            await _serviceproviderService.InsertAsync(Serviceprovider);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var serviceprovider = await _serviceproviderService.FindByIdAsync(id.Value);
            if (serviceprovider == null)
            {
                return NotFound();
            }
            return View(serviceprovider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _serviceproviderService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var serviceprovider = await _serviceproviderService.FindByIdAsync(id.Value);
            if (serviceprovider == null)
            {
                return NotFound();
            }
            return View(serviceprovider);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var serviceprovider = await _serviceproviderService.FindByIdAsync(id.Value);
            if (serviceprovider == null)
            {
                return NotFound();
            }
            List<Typeservice> typeservices = _typeserviceService.FindAll();
            ServiceproviderFormViewModel viewModel = new ServiceproviderFormViewModel
            {
                Serviceprovider = serviceprovider,
                Typeservices = typeservices,
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Serviceprovider Serviceprovider)
        {
            if (id != Serviceprovider.Id)
            {
                return BadRequest();
            }
            try
            {
                await _serviceproviderService.Update(Serviceprovider);
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