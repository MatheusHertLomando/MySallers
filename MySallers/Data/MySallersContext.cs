using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySallers.Models;

namespace MySallers.Data
{
    public class MySallersContext : DbContext
    {
        public MySallersContext (DbContextOptions<MySallersContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet <Vendedores> Vendedor { get; set; }
        public DbSet<HistoricoVendas> HistoricoVendas { get; set; }
    }
}
