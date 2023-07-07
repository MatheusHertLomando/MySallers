using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySallers.Models;
using MySallers.Models.Enums;

namespace MySallers.Data
{
    public class SeedingService
    {
        private MySallersContext _context;

        public SeedingService(MySallersContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedores.Any() || _context.HistoricoVendas.Any())
            {
                return; // Banco de Dados já poulado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Electronicos");
            Departamento d3 = new Departamento(3, "Móveis");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedores v1 = new Vendedores(1, "Lucas Felix", "lucas@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedores v2 = new Vendedores(2, "Maria Fernanda", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedores v3 = new Vendedores(3, "Alex Nunes", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedores v4 = new Vendedores(4, "Marta Prado", "marta@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedores v5 = new Vendedores(5, "Jorge Cerrado", "Jorge@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedores v6 = new Vendedores(6, "Carlos Luis", "carlos@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            HistoricoVendas r1 = new HistoricoVendas(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, v1);
            HistoricoVendas r2 = new HistoricoVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, v5);
            HistoricoVendas r3 = new HistoricoVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, v4);
            HistoricoVendas r4 = new HistoricoVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, v1);
            HistoricoVendas r5 = new HistoricoVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Faturado, v3);
            HistoricoVendas r6 = new HistoricoVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, v1);
            HistoricoVendas r7 = new HistoricoVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, v2);
            HistoricoVendas r8 = new HistoricoVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, v4);
            HistoricoVendas r9 = new HistoricoVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            HistoricoVendas r10 = new HistoricoVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, v6);
            HistoricoVendas r11 = new HistoricoVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Faturado, v2);
            HistoricoVendas r12 = new HistoricoVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            HistoricoVendas r13 = new HistoricoVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Faturado, v4);
            HistoricoVendas r14 = new HistoricoVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Faturado, v5);
            HistoricoVendas r15 = new HistoricoVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Faturado, v1);
            HistoricoVendas r16 = new HistoricoVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Faturado, v4);
            HistoricoVendas r17 = new HistoricoVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Faturado, v1);
            HistoricoVendas r18 = new HistoricoVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Faturado, v3);
            HistoricoVendas r19 = new HistoricoVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Faturado, v5);
            HistoricoVendas r20 = new HistoricoVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Faturado, v6);
            HistoricoVendas r21 = new HistoricoVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Faturado, v2);
            HistoricoVendas r22 = new HistoricoVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Faturado, v4);
            HistoricoVendas r23 = new HistoricoVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelado, v2);
            HistoricoVendas r24 = new HistoricoVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Faturado, v5);
            HistoricoVendas r25 = new HistoricoVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Faturado, v3);
            HistoricoVendas r26 = new HistoricoVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Faturado, v4);
            HistoricoVendas r27 = new HistoricoVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            HistoricoVendas r28 = new HistoricoVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Faturado, v3);
            HistoricoVendas r29 = new HistoricoVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Faturado, v5);
            HistoricoVendas r30 = new HistoricoVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Faturado, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedores.AddRange(v1, v2, v3, v4, v5, v6);

            _context.HistoricoVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }

    }
}
