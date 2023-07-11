using System.Collections.Generic;


namespace MySallers.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedores Vendedores { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
