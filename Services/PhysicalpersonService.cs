using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeuHelp.Data;
using MeuHelp.Services.Exceptions;
using System.Net.Http;
using System;

namespace MeuHelp.Services
{
    public class PhysicalpersonService
    {
        private readonly MeuHelpContext _context;
        public PhysicalpersonService(MeuHelpContext context)
        {
            _context = context;
        }
        public async Task<List<Physicalperson>> FindAllAsync()
        {
            return await _context.Physicalperson.ToListAsync();
        }
        public async Task InsertAsync(Physicalperson obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Physicalperson> FindByIdAsync(int id)
        {
            return await _context.Physicalperson.Include(obj => obj.Saleschannel)
                                                .FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Physicalperson.FindAsync(id);
            _context.Physicalperson.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Physicalperson obj)
        {
            bool hasAny = await _context.Physicalperson.AnyAsync(x => x.Id == obj.Id);
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
        public void GetAll()
        {
            HttpClient cpfs;
            cpfs = new HttpClient();
            cpfs.BaseAddress = new Uri("https://localhost:44394/api/values/");
            cpfs.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ApiCpf c = new ApiCpf();
            System.Net.Http.HttpResponseMessage response = cpfs.GetAsync("api/usuario").Result;
            if (response.IsSuccessStatusCode)
            {
                var usuarioUri = response.Headers.Location;
                var usuarios = response.Content.ReadAsAsync<IEnumerable<ApiCpf>>().Result;
            }
        }
    }
}
