using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuHelp.Data;
using MeuHelp.Services.Exceptions;

namespace MeuHelp.Services
{
    public class SaleschannelService
    {
        private readonly MeuHelpContext _context;
        public SaleschannelService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Saleschannel>> FindAllAsync()
        {
            return await _context.Saleschannel.OrderBy(x => x.Nome)
                                                        .ToListAsync();
        }
        public async Task InsertAsync(Saleschannel obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Saleschannel> FindByIdAsync(int id)
        {
            return await _context.Saleschannel.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Saleschannel.FindAsync(id);
            _context.Saleschannel.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Saleschannel obj)
        {
            bool hasAny = await _context.Saleschannel.AnyAsync(x => x.Id == obj.Id);
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
        public List<Saleschannel> FindAll()
        {
            return _context.Saleschannel.OrderBy(x => x.Nome).ToList();
        }
    }
}
