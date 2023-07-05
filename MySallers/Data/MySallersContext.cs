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

        public DbSet<MySallers.Models.Departamento> Departamento { get; set; }
    }
}
