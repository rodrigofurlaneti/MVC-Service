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
    public class RepresentativeService
    {
        private readonly MeuHelpContext _context;

        public RepresentativeService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Representative>> FindAllAsync()
        {
            return await _context.Representative.OrderBy(o => o.Name).ToListAsync();
        }

        public async Task InsertAsync(Representative obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Representative> FindByIdAsync(int id)
        {
            return await _context.Representative.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Representative.FindAsync(id);
            _context.Representative.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Representative obj)
        {
            bool hasAny = await _context.Representative.AnyAsync(x => x.Id == obj.Id);
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
        public List<Representative> FindAll()
        {
            return _context.Representative.OrderBy(x => x.Name).ToList();
        }
    }
}
