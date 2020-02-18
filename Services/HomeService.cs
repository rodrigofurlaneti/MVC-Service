using MeuHelp.Data;
using MeuHelp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Services
{
    public class HomeService
    {
        private readonly MeuHelpContext _context;
        public HomeService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Home>> FindAllAsync()
        {
            return await _context.Home.ToListAsync();
        }
        public async Task InsertAsync(Home obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Home> FindByIdAsyncCollaborator(int id)
        {
            return await _context.Home.Include(obj => obj.Collaborator).FirstOrDefaultAsync(obj => obj.CollaboratorId == id);
        }
        public async Task<Home> FindByIdAsyncPhysicalperson(int id)
        {
            return await _context.Home.Include(obj => obj.Physicalperson).FirstOrDefaultAsync(obj => obj.PhysicalpersonId == id);
        }
        //public async Task RemoveAsync(int id)
        //{
        //    try
        //    {
        //        var obj = await _context.Physicalperson.FindAsync(id);
        //        _context.Physicalperson.Remove(obj);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException e)
        //    {
        //        throw new IntegrityException("Can't delete Physicalperson because he/she has sales");
        //    }
        //}
        //public async Task UpdateAsync(Physicalperson obj)
        //{
        //    bool hasAny = await _context.Physicalperson.AnyAsync(x => x.Id == obj.Id);
        //    if (!hasAny)
        //    {
        //        throw new NotFoundException("Id not found");
        //    }
        //    try
        //    {
        //        _context.Update(obj);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException e)
        //    {
        //        throw new DbConcurrencyException(e.Message);
        //    }
        //}
    }
}
