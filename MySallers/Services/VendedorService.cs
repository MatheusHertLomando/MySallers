using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySallers.Data;
using MySallers.Models;
using Microsoft.EntityFrameworkCore;
using MySallers.Services.Exceptions;

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
            return _context.Vendedores.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedores.Find(id);
            _context.Vendedores.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Vendedores obj)
        {
            if (!_context.Vendedores.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
           catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
