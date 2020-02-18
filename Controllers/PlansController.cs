using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Views
{
    public class PlansController : Controller
    {
        private readonly PlanService _planService;
        public PlansController(PlanService planService)
        {
            _planService = planService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _planService.FindAllAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Plan plan)
        {
            await _planService.InsertAsync(plan);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var plan = await _planService.FindByIdAsync(id.Value);
            if (plan == null)
            {
                return NotFound();
            }
            return View(plan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _planService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var collaborator = await _planService.FindByIdAsync(id.Value);
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
            var plan = await _planService.FindByIdAsync(id.Value);
            if (plan == null)
            {
                return NotFound();
            }
            return View(plan);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Plan plan)
        {
            if (id != plan.Id)
            {
                return BadRequest();
            }
            try
            {
                await _planService.Update(plan);
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

