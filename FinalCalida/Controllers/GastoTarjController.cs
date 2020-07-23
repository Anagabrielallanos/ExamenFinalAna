using FinalCalida.Interfaze;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalCalida.Controllers
{
    public class GastoTarjController : Controller
    {
        readonly GastoInterfaze gastoInterfaze;
        readonly DatosInter datosInter;
        public GastoTarjController(GastoInterfaze gastoInterfaze, DatosInter datosInter)
        {
            this.gastoInterfaze = gastoInterfaze;
            this.datosInter = datosInter;
        }
        // GET: GastoTarj
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(GastoTarjeta gasto)
        {

            gastoInterfaze.SaveGasto(gasto);
            return RedirectToActionPermanent("Index", "Banco");
        }
        [HttpGet]
        public ActionResult Crear(int IdCuenta)
        {
            ViewBag.Cuenta = datosInter.Datos(IdCuenta);

            return View(new GastoTarjeta());
        }
    }
}