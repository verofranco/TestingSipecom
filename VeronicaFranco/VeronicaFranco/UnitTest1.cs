using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
namespace VeronicaFranco
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx?AspxAutoDetectCookieSupport=1";
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("demo");
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");
            driver.FindElement(By.Name("LoginUser$LoginButton")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("liClientes")).Click();
            Thread.Sleep(3000);
            //sbEle = driver.FindElement(By.Id("sbEle")).Click();

            //Actions builder = new Actions(driver);
            //// Move cursor to the Main Menu Element
            //builder.MoveToElement(mnEle).Perform();
            //// Giving 5 Secs for submenu to be displayed
            //Thread.Sleep(5000);
            //// Clicking on the Hidden SubMenu
            //driver.FindElement(By.Id("sbEle")).Click();
            driver.FindElement(By.Id("MainContent_btnAdd")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("Vero");
            var elem = new SelectElement(driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion")));
            elem.SelectByText("Pasaporte");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("PAS001");
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("2670023");
            driver.FindElement(By.Id("MainContent_txtExtension")).SendKeys("593");
            driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0986532003");
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Dir Av 152 Nrt 48");
            driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("verofranco@gmail.com");
            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("verofrancocl@gmail.com");
            //driver.FindElement(By.Id("MainContent_ddlEstado")).SendKeys("0430");

            driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Alert().Accept();


        }

    }
}
