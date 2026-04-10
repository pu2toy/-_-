using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Models;

namespace Task01.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<ClientModel> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=crm.db");
    }
}
