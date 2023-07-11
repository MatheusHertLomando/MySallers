using System.Collections.Generic;
using System.Linq;
using MySallers.Data;
using MySallers.Models;

namespace MySallers.Services
{
    public class DepartamentoService
    {
        private readonly MySallersContext _context;

        public DepartamentoService(MySallersContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Name).ToList();
        }
    }
}
