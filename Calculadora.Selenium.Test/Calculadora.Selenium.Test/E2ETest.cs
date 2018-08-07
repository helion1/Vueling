using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Facade.ApiTests2.Controllers {

    [TestClass]
    public class RateApiControllerSeleniumTest {
        private static IWebDriver Driver;
        private static readonly String base_url = ConfigurationManager.AppSettings["baseUrl"]
                                        + ConfigurationManager.AppSettings["UrlGetAllRates"];

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context) {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(base_url);
        }


        [AssemblyCleanup]
        public static void AssemblyTearDown() {
            Driver.Close();
            Driver.Quit();
        }



        [TestMethod]
        public void SeleniumTestUsingCSharp() {
            var title = Driver.FindElement(By.Id("title"));

            var substraction = Driver.FindElement(By.Id("substraction"));
            var division = Driver.FindElement(By.Id("division"));
            var multiply = Driver.FindElement(By.Id("multiply"));

            //TITLE
            Assert.AreEqual(title.Text, "Calculadora");

            //SUM
            Driver.FindElement(By.Id("field1")).Clear();
            Driver.FindElement(By.Id("field2")).Clear();
            Driver.FindElement(By.Id("result")).Clear();

            Driver.FindElement(By.Id("field1")).SendKeys("5");
            Driver.FindElement(By.Id("field2")).SendKeys("3");
            Driver.FindElement(By.Id("sum")).Click();
            var result = Driver.FindElement(By.Id("result"));

            Assert.AreEqual(result.ToString(), "8");


            //SUBSTRACTION
            Driver.FindElement(By.Id("field1")).Clear();
            Driver.FindElement(By.Id("field2")).Clear();
            Driver.FindElement(By.Id("result")).Clear();

            Driver.FindElement(By.Id("field1")).SendKeys("5");
            Driver.FindElement(By.Id("field2")).SendKeys("3");
            Driver.FindElement(By.Id("substraction")).Click();
            result = Driver.FindElement(By.Id("result"));

            Assert.AreEqual(result.ToString(), "2");


            //MULTIPLY
            Driver.FindElement(By.Id("field1")).Clear();
            Driver.FindElement(By.Id("field2")).Clear();
            Driver.FindElement(By.Id("result")).Clear();

            Driver.FindElement(By.Id("field1")).SendKeys("5");
            Driver.FindElement(By.Id("field2")).SendKeys("3");
            Driver.FindElement(By.Id("multiply")).Click();
            result = Driver.FindElement(By.Id("result"));

            Assert.AreEqual(result.ToString(), "15");


            //DIVISION
            Driver.FindElement(By.Id("field1")).Clear();
            Driver.FindElement(By.Id("field2")).Clear();
            Driver.FindElement(By.Id("result")).Clear();

            Driver.FindElement(By.Id("field1")).SendKeys("6");
            Driver.FindElement(By.Id("field2")).SendKeys("3");
            Driver.FindElement(By.Id("division")).Click();
            result = Driver.FindElement(By.Id("result"));

            Assert.AreEqual(result.ToString(), "2");
            
        }

    }
}
