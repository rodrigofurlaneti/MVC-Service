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
    public class LegalpersonService
    {
        private readonly MeuHelpContext _context;
        public LegalpersonService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Legalperson>> FindAllAsync()
        {
            return await _context.Legalperson.OrderBy(x => x.RazaoSocial).ToListAsync();
        }
        public List<Legalperson> FindAll()
        {
            return _context.Legalperson.OrderBy(x => x.RazaoSocial).ToList();
        }
        public async Task InsertAsync(Legalperson legalperson)
        {
            _context.Add(legalperson);
            await _context.SaveChangesAsync();
        }
        public Legalperson FindById(int id)
        {
            return _context.Legalperson.FirstOrDefault(obj => obj.Id == id);
        }
        public async Task<Legalperson> FindByIdAsync(int id)
        {
            return await _context.Legalperson.Include(o => o.Typeservice)
                                             .FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Legalperson.FindAsync(id);
            _context.Legalperson.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Legalperson obj)
        {
            bool hasAny = await _context.Legalperson.AnyAsync(x => x.Id == obj.Id);
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
