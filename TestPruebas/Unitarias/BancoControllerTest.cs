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
    public class BancoControllerTest
    {
        [Test]
        public void DebePoderRetornarUnaListaDeCuentasMasSuGasto()
        {
            var interfa = new Mock<DatosInter>();

            interfa.Setup(o => o.GetDatos()).Returns(new List<Datos>());

            var controller = new BancoController(interfa.Object);

            var view = controller.Index() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
            Assert.IsNotInstanceOf<RedirectResult>(view);
            Assert.IsInstanceOf<List<Datos>>(view.Model);
        }
        [Test]
        public void DebePoderGuardarDatos()
        {
            var interfa = new Mock<DatosInter>();

            var datos = new Datos();

            interfa.Setup(o => o.Save(datos));


            var controller = new BancoController(interfa.Object);

            var view = controller.Crear(datos);

            Assert.IsInstanceOf<RedirectToRouteResult>(view);

        }
    }
}
