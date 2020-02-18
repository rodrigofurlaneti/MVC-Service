using MeuHelp.Data;
using MeuHelp.Models;
using MeuHelp.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Services
{
    public class DiscountService
    {
        private readonly MeuHelpContext _context;

        public DiscountService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Discount>> FindAllAsync()
        {
            return await _context.Discount.OrderBy(o => o.NameDiscount).ToListAsync();
        }

        public async Task InsertAsync(Discount obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Discount> FindByIdAsync(int id)
        {
            return await _context.Discount.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Discount.FindAsync(id);
            _context.Discount.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Discount obj)
        {
            bool hasAny = await _context.Discount.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
        public List<Discount> FindAll()
        {
            return _context.Discount.OrderBy(x => x.NameDiscount).ToList();
        }
    }
}
