using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01.Data
{
    public class ClientRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public async Task<List<ClientModel>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task AddClientAsync(ClientModel client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(ClientModel client)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(ClientModel client)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }

}
