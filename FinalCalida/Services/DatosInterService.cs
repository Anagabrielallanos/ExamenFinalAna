using FinalCalida.DB;
using FinalCalida.Interfaze;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalCalida.Services
{
    public class DatosInterService : DatosInter
    {
        readonly SimuladorContext context;
        private ModelStateDictionary modelState;
        public DatosInterService(SimuladorContext context)
        {
            this.context = context;
        }

        public List<Datos> Datos(int id)
        {
            var dato = context.Datos.Where(p => p.IdDatos == id).ToList();
            return dato;
        }

        public List<Datos> GetDatos()
        {
            var listDATOS = context.Datos.Include(a => a.GastoTarjetas).ToList();
            return listDATOS;
        }

        public bool IsValid()
        {
            return modelState.IsValid;
        }

        public void Save(Datos datos)
        {
            context.Datos.Add(datos);
            context.SaveChanges();
        }

        public void Validate(GastoTarjeta categoria, ModelStateDictionary modelState)
        {
            var crit = context.Datos;

            this.modelState = modelState;
            if (crit.Any(o => o.SadldoInicial < categoria.Monto))
                modelState.AddModelError("Monto", "No cuenta con salfo suficiente");
        }
    }
}