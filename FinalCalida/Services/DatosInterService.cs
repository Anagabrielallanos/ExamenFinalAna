using FinalCalida.DB;
using FinalCalida.Interfaze;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalCalida.Services
{
    public class DatosInterService : DatosInter
    {
        readonly SimuladorContext context;
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

        public void Save(Datos datos)
        {
            context.Datos.Add(datos);
            context.SaveChanges();
        }
    }
}