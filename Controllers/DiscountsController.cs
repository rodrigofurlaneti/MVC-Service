using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeuHelp.Data;
using MeuHelp.Models;
using MeuHelp.Services;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Views
{
    public class DiscountsController : Controller
    {
        private readonly DiscountService _discountService;
        public DiscountsController(DiscountService discountService)
        {
            _discountService = discountService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _discountService.FindAllAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var discount = await _discountService.FindByIdAsync(id.Value);
            if (discount == null)
            {
                return NotFound();
            }
            return View(discount);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Discount discount)
        {
            await _discountService.InsertAsync(discount);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var discount = await _discountService.FindByIdAsync(id.Value);
            if (discount == null)
            {
                return NotFound();
            }
            return View(discount);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Discount discount)
        {
            if (id != discount.Id)
            {
                return BadRequest();
            }
            try
            {
                await _discountService.Update(discount);
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var discount = await _discountService.FindByIdAsync(id.Value);
            if (discount == null)
            {
                return NotFound();
            }
            return View(discount);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _discountService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        //private bool DiscountExists(int id)
        //{
        //    return _discountService.FindAll(e => e.Id == id);
        //}
    }
}
