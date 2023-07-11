using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySallers.Data;
using MySallers.Models;

namespace MySallers.Services
{
    public class VendedorService
    {
        private readonly MySallersContext _context;

        public VendedorService(MySallersContext context)
        {
            _context = context;
        }

        public List<Vendedores> FindAll()
        {
            return _context.Vendedores.ToList();
        }

        public void Insert(Vendedores obj)
        {
            
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
