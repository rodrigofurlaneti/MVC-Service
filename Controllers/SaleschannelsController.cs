using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using MeuHelp.Data;
using MeuHelp.Services;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Views
{
    public class SaleschannelsController : Controller
    {
        private readonly SaleschannelService _SaleschannelService;
        public SaleschannelsController(SaleschannelService SaleschannelService)
        {
            _SaleschannelService = SaleschannelService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _SaleschannelService.FindAllAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Saleschannel Saleschannel)
        {
            await _SaleschannelService.InsertAsync(Saleschannel);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Saleschannel = await _SaleschannelService.FindByIdAsync(id.Value);
            if (Saleschannel == null)
            {
                return NotFound();
            }
            return View(Saleschannel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _SaleschannelService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var collaborator = await _SaleschannelService.FindByIdAsync(id.Value);
            if (collaborator == null)
            {
                return NotFound();
            }
            return View(collaborator);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Saleschannel = await _SaleschannelService.FindByIdAsync(id.Value);
            if (Saleschannel == null)
            {
                return NotFound();
            }
            return View(Saleschannel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Saleschannel Saleschannel)
        {
            if (id != Saleschannel.Id)
            {
                return BadRequest();
            }
            try
            {
                await _SaleschannelService.Update(Saleschannel);
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