using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuHelp.Data;
using MeuHelp.Services.Exceptions;
namespace MeuHelp.Services
{
        public class ShippingwayService
        {
        private readonly MeuHelpContext _context;
        public ShippingwayService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Shippingway>> FindAllAsync()
        {
            return await _context.Shippingway   .OrderBy(x => x.Nome)
                                                .ToListAsync();
        }
        public async Task InsertAsync(Shippingway obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Shippingway> FindByIdAsync(int id)
        {
            return await _context.Shippingway.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Shippingway.FindAsync(id);
            _context.Shippingway.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Shippingway obj)
        {
            bool hasAny = await _context.Shippingway.AnyAsync(x => x.Id == obj.Id);
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
        public List<Shippingway> FindAll()
        {
            return _context.Shippingway.OrderBy(x => x.Nome).ToList();
        }
    }
}
