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

        public Vendedores FindById(int id)
        {
            return _context.Vendedores.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedores.Find(id);
            _context.Vendedores.Remove(obj);
            _context.SaveChanges();
        }
    }
}
