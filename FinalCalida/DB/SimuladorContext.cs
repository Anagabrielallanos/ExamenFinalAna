using FinalCalida.DB.Map;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalCalida.DB
{
    public class SimuladorContext : DbContext
    {
        public IDbSet<Datos> Datos { get; set; }
        public IDbSet<GastoTarjeta> GastoTarjeta { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new GastosTarjetaMap());
            modelBuilder.Configurations.Add(new DatosMap());

        }
    }
}