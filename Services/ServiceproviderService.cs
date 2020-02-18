using MeuHelp.Data;
using MeuHelp.Models;
using MeuHelp.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MeuHelp.Services
{
    public class ServiceproviderService
    {
        private readonly MeuHelpContext _context;
        public ServiceproviderService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Serviceprovider>> FindAllAsync()
        {
            return await _context.Serviceprovider   .Include(o => o.Typeservice)
                                                    .ToListAsync();
        }
        public async Task InsertAsync(Serviceprovider obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Serviceprovider> FindByIdAsync(int id)
        {
            return await _context.Serviceprovider   .Include(o => o.Typeservice)
                                                    .FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Serviceprovider.FindAsync(id);
            _context.Serviceprovider.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Serviceprovider obj)
        {
            bool hasAny = await _context.Serviceprovider.AnyAsync(x => x.Id == obj.Id);
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