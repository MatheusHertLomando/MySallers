using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySallers.Models;

namespace MySallers.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();

            list.Add(new Departamento { Id = 1, Name = "Eletronicos"});
            list.Add(new Departamento { Id = 2, Name = "Roupas" });

            return View(list);
        }
    }
}
