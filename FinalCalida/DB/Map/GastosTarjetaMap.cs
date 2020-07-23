using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;



namespace FinalCalida.DB.Map
{
    public class GastosTarjetaMap : EntityTypeConfiguration<GastoTarjeta>
    {
        public GastosTarjetaMap()
        {
            ToTable("GastoTarjeta");
            HasKey(g => g.IdGastoTarjeta);

            HasRequired(p => p.Datos)
                .WithMany(a => a.GastoTarjetas)
                .HasForeignKey(i => i.DatosId);
        }
    }
}