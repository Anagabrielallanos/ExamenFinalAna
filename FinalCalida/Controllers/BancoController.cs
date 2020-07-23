using FinalCalida.Interfaze;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalCalida.Controllers
{
    public class BancoController : Controller
    {
        readonly DatosInter datosInter;
        public BancoController(DatosInter datosInter)
        {
            this.datosInter = datosInter;
        }
        // GET: Banco
        public ActionResult Index()
        {
            var Datos = datosInter.GetDatos();

            return View(Datos);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View(new Datos());
        }
        [HttpPost]
        public ActionResult Crear(Datos datos)
        {

            datosInter.Save(datos);
            return RedirectToAction("Index");
        }

    }
}
