using FinalCalida.Controllers;
using FinalCalida.Interfaze;
using FinalCalida.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TestPruebas.Unitarias
{
    [TestFixture]
    public class GastoTarjControllerTest
    {
        [Test]
        public void DebePoderGuardarUnGasto()
        {

            var interfa1 = new Mock<GastoInterfaze>();
            var interfa2 = new Mock<DatosInter>();

            var gastotarjeta = new GastoTarjeta();

            interfa1.Setup(o => o.SaveGasto(gastotarjeta));

            var controller = new GastoTarjController(interfa1.Object, null);

            var view = controller.Crear(gastotarjeta) as ActionResult;

            Assert.IsInstanceOf<ActionResult>(view);

        }
        [Test]
        public void NoDebePoderGuardarUnGasto()
        {

            var interfa1 = new Mock<GastoInterfaze>();
            var interfa2 = new Mock<DatosInter>();

            var gastotarjeta = new GastoTarjeta();

            interfa1.Setup(o => o.SaveGasto(gastotarjeta));

            var controller = new GastoTarjController(interfa1.Object, null);

            var view = controller.Crear(gastotarjeta) as ActionResult;

            Assert.IsInstanceOf<ActionResult>(view);

        }
    }
}
