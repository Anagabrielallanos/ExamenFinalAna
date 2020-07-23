using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCalida.Models
{
    public class Datos
    {
        public int IdDatos { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int SadldoInicial { get; set; }
        public IList<GastoTarjeta> GastoTarjetas { get; set; }
    }
}