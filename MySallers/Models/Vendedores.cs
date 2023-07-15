using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MySallers.Models
{
    public class Vendedores
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} não pode conter menos de {2} ou maximo de {1} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Coloque um email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} Tem que ser {1} e {2}")]
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
