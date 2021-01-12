using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ShopUnitTests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void openapptest()
        {
            driver.Url = "https://localhost:44356/";
        }

        [TearDown]
        public void endtest()
        {
            driver.Close();
        }
    }
}