using MeuHelp.Data;
using MeuHelp.Models;
using MeuHelp.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MeuHelp.Services
{
    public class PartnerService
    {
        private readonly MeuHelpContext _context;
        public PartnerService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Partner>> FindAllAsync()
        {
            return await _context.Partner.OrderBy(x => x.Nome)
                                                .ToListAsync();
        }
        public async Task InsertAsync(Partner obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Partner> FindByIdAsync(int id)
        {
            return await _context.Partner.Include(o => o.Typeservice)
                                                    .FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Partner.FindAsync(id);
            _context.Partner.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Partner obj)
        {
            bool hasAny = await _context.Partner.AnyAsync(x => x.Id == obj.Id);
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
    }
}