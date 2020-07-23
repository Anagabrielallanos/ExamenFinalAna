using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCalida.Models
{
    public class GastoTarjeta
    {
        public int IdGastoTarjeta { get; set; }
        public string Cuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public Datos Datos { get; set; }
        public int DatosId { get; set; }

    }
}