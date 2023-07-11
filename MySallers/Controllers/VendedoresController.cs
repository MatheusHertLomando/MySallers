using Microsoft.AspNetCore.Mvc;
using MySallers.Models;
using MySallers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySallers.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Vendedores Vendedor)
        {
            _vendedorService.Insert(Vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
