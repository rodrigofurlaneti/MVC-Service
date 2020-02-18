using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Services.Exceptions;
using MeuHelp.Services;

namespace MeuHelp.Views
{
    public class ShippingwaysController : Controller
    {
        private readonly ShippingwayService _shippingwayService;
        public ShippingwaysController(ShippingwayService shippingwayService)
        {
            _shippingwayService = shippingwayService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _shippingwayService.FindAllAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Shippingway shippingway)
        {
            await _shippingwayService.InsertAsync(shippingway);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shippingway = await _shippingwayService.FindByIdAsync(id.Value);
            if (shippingway == null)
            {
                return NotFound();
            }
            return View(shippingway);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _shippingwayService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shippingway = await _shippingwayService.FindByIdAsync(id.Value);
            if (shippingway == null)
            {
                return NotFound();
            }
            return View(shippingway);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shippingway = await _shippingwayService.FindByIdAsync(id.Value);
            if (shippingway == null)
            {
                return NotFound();
            }
            return View(shippingway);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Shippingway Shippingway)
        {
            if (id != Shippingway.Id)
            {
                return BadRequest();
            }
            try
            {
                await _shippingwayService.Update(Shippingway);
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

