using System;
using MySallers.Models.Enums;

namespace MySallers.Models
{
    public class HistoricoVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedores Vendedor { get; set; }

        public HistoricoVendas()
        {
        }

        public HistoricoVendas(int id, DateTime data, double quantidade, StatusVenda status, Vendedores vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
