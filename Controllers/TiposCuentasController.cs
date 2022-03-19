using Dapper;
using ManejoPresupuesto.Models;
using ManejoPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Controllers;

    public class TiposCuentasController : Controller
    {
        private readonly IRepositorioTiposCuentas _repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            _repositorioTiposCuentas = repositorioTiposCuentas;
        }
        
        [HttpGet]
        public IActionResult Crear()
        {
            //var modelo = new TipoCuenta() {nombre = "Máximo"};
            return View("/Views/Home/TiposCuentas/Crear.cshtml");
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View("/Views/Home/TiposCuentas/Crear.cshtml", tipoCuenta);
            }

            tipoCuenta.usuario_id = 1;
            _repositorioTiposCuentas.Crear(tipoCuenta);
            
            return View("/Views/Home/TiposCuentas/Crear.cshtml");
        }
    }

