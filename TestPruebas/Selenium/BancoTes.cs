using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPruebas.Selenium
{
    [TestFixture]
    public class BancoTes
    {
        ChromeDriver Banco = new ChromeDriver();
        [Test]
        public void DebeIngresarYMostrarCuentasYgastos()
        {
            Banco.Url = Global.URL;
            Assert.IsTrue(Banco.Url.EndsWith("/Banco"));
            Banco.Close();
        }
        [Test]
        public void DebeIngresarYMostrarRegistroDeGasto()
        {
            Banco.Url = Global.URL;
            Banco.FindElementById("Crear").Click();
            Assert.IsTrue(Banco.Url.EndsWith("GastoTarj/Crear?IdCuenta=1"));
            Banco.Close();
        }
        [Test]
        public void DebePoderRegistrarUnGasto()
        {
            Banco.Url = Global.URL;
            Banco.FindElementById("Crear").Click();
            Banco.FindElementById("Monto").SendKeys("99");
            Banco.FindElementById("Fecha").SendKeys("20/07/2020");
            Banco.FindElementById("Descripcion").SendKeys("Compra");
            Banco.FindElementById("TarjetaId").SendKeys("Hola");
            Banco.FindElementById("Guardar").Click();
            Assert.IsTrue(Banco.Url.EndsWith("/Banco"));
            Banco.Close();

        }
        [Test]
        public void NoDebePoderRegistrarUnGastoSiElMontoSuperaElSAdo()
        {
            Banco.Url = Global.URL;
            Banco.FindElementById("Crear").Click();
            Banco.FindElementById("Monto").SendKeys("200");
            Banco.FindElementById("Fecha").SendKeys("20/07/2020");
            Banco.FindElementById("Descripcion").SendKeys("Compra");
            Banco.FindElementById("TarjetaId").SendKeys("Hola");
            Banco.FindElementById("Guardar").Click();
            Assert.IsTrue(Banco.Url.EndsWith("/GastoTarj/Crear"));
            Banco.Close();

        }
        [Test]

        public void DebePoderMostrarVisataParaRegistrarCuenta()
        {
            Banco.Url = Global.URL;
            Banco.FindElementById("registrar").Click();
            Assert.IsTrue(Banco.Url.EndsWith("Banco/Crear"));
            Banco.Close();
        }
        [Test]
        public void DebePoderRegistrarCuenta()
        {
            Banco.Url = Global.URL;
            Banco.FindElementById("registrar").Click();
            Banco.FindElementById("Nombre").SendKeys("Hola Mundo");
            Banco.FindElementById("Categoria").SendKeys("Credito");
            Banco.FindElementById("SaldoInicial").SendKeys("2000");
            Banco.FindElementById("Guardar").Click();
            Assert.IsTrue(Banco.Url.EndsWith("/Banco"));
            Banco.Close();
        }
    }
}
