using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlacksmithManagerWeb.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JMP-PC\SQLEXPRESS; Database = BlacksmithManagerWeb; Trusted_Connection =true");
        }
    }
}
