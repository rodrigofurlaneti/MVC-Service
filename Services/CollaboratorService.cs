using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuHelp.Data;
using MeuHelp.Services.Exceptions;
namespace MeuHelp.Services
{
    public class CollaboratorService
    {
        private readonly MeuHelpContext _context;
        public CollaboratorService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Collaborator>> FindAllAsync()
        {
            return await _context.Collaborator  .OrderBy(x => x.Nome)
                                                .Include(o => o.Legalperson)
                                                .ToListAsync();
        }

        public async Task InsertAsync(Collaborator obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Collaborator> FindByIdAsync(int id)
        {
            return await _context.Collaborator  .Include(o => o.Legalperson)
                                                .Include(o => o.Plan)
                                                .Include(o => o.Saleschannel)
                                                .Include(o => o.Shippingway)
                                                .FirstOrDefaultAsync(o => o.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Collaborator.FindAsync(id);
            _context.Collaborator.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Collaborator obj)
        {
            bool hasAny = await _context.Collaborator.AnyAsync(x => x.Id == obj.Id);
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
