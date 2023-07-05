using System.Collections.Generic;
using System;
using System.Linq;

namespace MySallers.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedores Vendedor)
        {
            Vendedores.Add(Vendedor);
        }

        public double TotalVendas(DateTime Inicial, DateTime Final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendas(Inicial, Final));
        }
    }
}
