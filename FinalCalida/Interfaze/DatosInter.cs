using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCalida.Interfaze
{
    public interface DatosInter
    {
        List<Datos> GetDatos();
        List<Datos> Datos(int id);
        void Save(Datos datos);
    }
}