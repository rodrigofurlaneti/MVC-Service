using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuHelp.Models;
using MeuHelp.Models.ViewModels;
using MeuHelp.Services;
using System.Collections.Generic;
using MeuHelp.Services.Exceptions;
namespace MeuHelp.Views
{
    public class CollaboratorsController : Controller
    {
        private readonly CollaboratorService _collaboratorService;
        private readonly LegalpersonService _legalpersonService;
        private readonly PlanService _planService;
        private readonly SaleschannelService _saleschannelService;
        private readonly ShippingwayService _shippingwayService;
        public CollaboratorsController(CollaboratorService collaboratorService, LegalpersonService legalpersonService, PlanService planService, SaleschannelService saleschannelService, ShippingwayService shippingwayService)
        {
            _collaboratorService = collaboratorService;
            _legalpersonService = legalpersonService;
            _planService = planService;
            _saleschannelService = saleschannelService;
            _shippingwayService = shippingwayService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _collaboratorService.FindAllAsync());
        }
        public async Task<IActionResult> Create()
        {
            var legalpersons = await _legalpersonService.FindAllAsync();
            var saleschannels = await _saleschannelService.FindAllAsync();
            var plans = await _planService.FindAllAsync();
            var shippingways = await _shippingwayService.FindAllAsync();
            var viewModel = new CollaboratorFormViewModel { Legalpersons = legalpersons, Saleschannels = saleschannels, Plans = plans, Shippingways = shippingways };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Collaborator collaborator)
        {
            await _collaboratorService.InsertAsync(collaborator);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var collaborator = await _collaboratorService.FindByIdAsync(id.Value);
            if (collaborator == null)
            {
                return NotFound();
            }
            return View(collaborator);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _collaboratorService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var collaborator = await _collaboratorService.FindByIdAsync(id.Value);
            if (collaborator == null)
            {
                return NotFound();
            }
            return View(collaborator);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var collaborator = await _collaboratorService.FindByIdAsync(id.Value);
            if (collaborator == null)
            {
                return NotFound();
            }
            List<Legalperson> legalpersons = _legalpersonService.FindAll();
            List<Shippingway> shippingways = _shippingwayService.FindAll();
            List<Saleschannel> saleschannels = _saleschannelService.FindAll();
            List<Plan> plans = _planService.FindAll();
            CollaboratorFormViewModel viewModel = new CollaboratorFormViewModel
            {
                Collaborator = collaborator,
                Legalpersons = legalpersons,
                Shippingways = shippingways,
                Saleschannels = saleschannels,
                Plans = plans
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Collaborator collaborator)
        {
            if(id != collaborator.Id)
            {
                return BadRequest();
            }
            try
            {
                await _collaboratorService.Update(collaborator);
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
