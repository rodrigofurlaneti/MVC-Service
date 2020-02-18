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
    public class TypeserviceService
    {
        private readonly MeuHelpContext _context;
        public TypeserviceService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Typeservice>> FindAllAsync()
        {
            return await _context.Typeservice.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task InsertAsync(Typeservice obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Typeservice> FindByIdAsync(int id)
        {
            return await _context.Typeservice.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Typeservice.FindAsync(id);
            _context.Typeservice.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Typeservice obj)
        {
            bool hasAny = await _context.Typeservice.AnyAsync(x => x.Id == obj.Id);
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
        public List<Typeservice> FindAll()
        {
            return _context.Typeservice.OrderBy(x => x.Nome).ToList();
        }
    }
}
