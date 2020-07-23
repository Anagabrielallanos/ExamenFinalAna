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
            ModelStateDictionary modelState = new ModelStateDictionary();
            var interfa1 = new Mock<GastoInterfaze>();
            var interfa2 = new Mock<DatosInter>();

            var gastotarjeta = new GastoTarjeta();
            var criterio = new GastoTarjeta();

            interfa1.Setup(o => o.SaveGasto(gastotarjeta));
            interfa2.Setup(o => o.IsValid()).Returns(true);
            interfa2.Setup(o => o.Validate(gastotarjeta,modelState));
            var controller = new GastoTarjController(interfa1.Object, interfa2.Object);

            var view = controller.Crear(gastotarjeta) as ActionResult;

            Assert.IsInstanceOf<ActionResult>(view);

        }
        [Test]
        public void NoDebePoderGuardarUnGasto()
        {

            ModelStateDictionary modelState = new ModelStateDictionary();
            var interfa1 = new Mock<GastoInterfaze>();
            var interfa2 = new Mock<DatosInter>();

            var gastotarjeta = new GastoTarjeta();
            var criterio = new GastoTarjeta();

            interfa1.Setup(o => o.SaveGasto(gastotarjeta));
            interfa2.Setup(o => o.IsValid()).Returns(false);
            interfa2.Setup(o => o.Validate(gastotarjeta, modelState));
            var controller = new GastoTarjController(interfa1.Object, interfa2.Object);

            var view = controller.Crear(gastotarjeta) as ViewResult;

            Assert.IsInstanceOf<GastoTarjeta>(view.Model);

        }
    }
}
