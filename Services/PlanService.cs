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
    public class PlanService
    {
        private readonly MeuHelpContext _context;

        public PlanService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Plan>> FindAllAsync()
        {
            return await _context.Plan.OrderBy(o => o.Nome).ToListAsync();
        }

        public async Task InsertAsync(Plan obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Plan> FindByIdAsync(int id)
        {
            return await _context.Plan.FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Plan.FindAsync(id);
            _context.Plan.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Plan obj)
        {
            bool hasAny = await _context.Plan.AnyAsync(x => x.Id == obj.Id);
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
        public List<Plan> FindAll()
        {
            return _context.Plan.OrderBy(x => x.Nome).ToList();
        }
    }
}
