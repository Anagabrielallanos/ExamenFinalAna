using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace FinalCalida.DB
{
    public class DatosMap : EntityTypeConfiguration<Datos>
    {
        public DatosMap()
        {
            ToTable("Datos");
            HasKey(o => o.IdDatos);
        }
    }
}