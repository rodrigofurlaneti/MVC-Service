using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Models.ViewModels;
using MeuHelp.Services;
using System.Collections.Generic;
using MeuHelp.Services.Exceptions;
using System.Net.Http;
using System;

namespace MeuHelp.Views
{
    public class PhysicalpersonsController : Controller
    {
        private readonly PhysicalpersonService _physicalpersonService;
        private readonly SaleschannelService _saleschannelService;
        private readonly PlanService _planService;
        private readonly ShippingwayService _shippingwayService;

        public PhysicalpersonsController(PhysicalpersonService physicalpersonService, SaleschannelService saleschannelService, PlanService planService, ShippingwayService shippingwayService)
        {
            _physicalpersonService = physicalpersonService;
            _saleschannelService = saleschannelService;
            _planService = planService;
            _shippingwayService = shippingwayService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _physicalpersonService.FindAllAsync());
        }
        public async Task<IActionResult> Create()
        {
            var saleschannels = await _saleschannelService.FindAllAsync();
            var plans = await _planService.FindAllAsync();
            var shippingways = await _shippingwayService.FindAllAsync();
            var viewModel = new PhysicalpersonFormViewModel 
            { 
                Saleschannels = saleschannels, 
                Plans = plans, 
                Shippingways = shippingways 
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Physicalperson physicalperson)
        {
            await _physicalpersonService.InsertAsync(physicalperson);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var physicalperson = await _physicalpersonService.FindByIdAsync(id.Value);
            if (physicalperson == null)
            {
                return NotFound();
            }
            return View(physicalperson);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _physicalpersonService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var physicalperson = await _physicalpersonService.FindByIdAsync(id.Value);
            if (physicalperson == null)
            {
                return NotFound();
            }
            return View(physicalperson);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var physicalperson = await _physicalpersonService.FindByIdAsync(id.Value);
            if (physicalperson == null)
            {
                return NotFound();
            }
            List<Shippingway> shippingways = _shippingwayService.FindAll();
            List<Saleschannel> saleschannels = _saleschannelService.FindAll();
            List<Plan> plans = _planService.FindAll();
            PhysicalpersonFormViewModel viewModel = new PhysicalpersonFormViewModel
            {
                Physicalperson = physicalperson,
                Shippingways = shippingways,
                Saleschannels = saleschannels,
                Plans = plans
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Physicalperson physicalperson)
        {
            if (id != physicalperson.Id)
            {
                return BadRequest();
            }
            try
            {
                await _physicalpersonService.Update(physicalperson);
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
