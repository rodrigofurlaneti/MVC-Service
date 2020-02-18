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
    public class TypeservicesController : Controller
    {
        private readonly TypeserviceService _typeserviceService;
        public TypeservicesController(TypeserviceService typeserviceService)
        {
            _typeserviceService = typeserviceService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _typeserviceService.FindAllAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Typeservice typeservice)
        {
            await _typeserviceService.InsertAsync(typeservice);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Typeservice = await _typeserviceService.FindByIdAsync(id.Value);
            if (Typeservice == null)
            {
                return NotFound();
            }
            return View(Typeservice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _typeserviceService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Typeservice = await _typeserviceService.FindByIdAsync(id.Value);
            if (Typeservice == null)
            {
                return NotFound();
            }
            return View(Typeservice);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var typeservice = await _typeserviceService.FindByIdAsync(id.Value);
            if (typeservice == null)
            {
                return NotFound();
            }
            
            return View(typeservice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Typeservice typeservice)
        {
            if (id != typeservice.Id)
            {
                return BadRequest();
            }
            try
            {
                await _typeserviceService.Update(typeservice);
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
