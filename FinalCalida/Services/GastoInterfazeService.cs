using FinalCalida.DB;
using FinalCalida.Interfaze;
using FinalCalida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCalida.Services
{
    public class GastoInterfazeService : GastoInterfaze
    {
        readonly SimuladorContext context;

        public GastoInterfazeService(SimuladorContext context)
        {
            this.context = context;
        }
        public void SaveGasto(GastoTarjeta gastoTarjeta)
        {
            context.GastoTarjeta.Add(gastoTarjeta);
            context.SaveChanges();
        }
    }
}