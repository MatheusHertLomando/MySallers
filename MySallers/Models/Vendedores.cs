using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MySallers.Models
{
    public class Vendedores
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<HistoricoVendas> Vendas { get; set; } = new List<HistoricoVendas>();

        public Vendedores()
        {
        }

        public Vendedores(int id, string name, string email, DateTime dataNasc, double SalarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNasc = DataNasc;
            SalarioBase = SalarioBase;
            Departamento = departamento;
        }

        public void AddVendas(HistoricoVendas hv)
        {
            Vendas.Add(hv);
        }
        public void RemoveVendas(HistoricoVendas hv)
        {
            Vendas.Remove(hv);
        }
        public double TotalVendas(DateTime Inicial, DateTime Final)
        {
            return Vendas.Where(hv => hv.Data >= Inicial && hv.Data <= Final).Sum(hv => hv.Quantidade);

        }
    }
}
