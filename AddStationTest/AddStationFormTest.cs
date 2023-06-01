using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AddStationTest
{
    [TestClass]
    public class AddStationFormTest
    {
        private IWebDriver driver;
        private const string BaseUrl = "https://localhost:7109";

        [TestInitialize]
        public void TestInitialize() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void FormAddStation()
        {
            driver.Navigate().GoToUrl(BaseUrl + "/Station/Create");
            driver.FindElement(By.CssSelector("input#Name")).SendKeys("Test Station");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            Assert.IsTrue(driver.Url.Contains(BaseUrl + "/Station/Index"));
            Assert.IsTrue(driver.PageSource.Contains("New Station"));
        }
    }
}