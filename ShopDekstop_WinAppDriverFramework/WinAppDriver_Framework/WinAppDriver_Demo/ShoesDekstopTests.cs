using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace WinAppDriver_Demo
{
    [TestClass]
    public class ShoesShopTests
    {

        [TestFixture]
        public class ShoesTests
        {
            private WindowsDriver<WindowsElement> _driver;
            [SetUp]
            public void TestInit()
            {
                var options = new AppiumOptions();
                options.AddAdditionalCapability("app", @"C:\Users\AMD\Desktop\курсач\ShopDekstop\ShoppingCart-master\ShoppingCart\bin\Debug\ShoppingCart.exe");
                //options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
            [TearDown]
            public void TestCleanup()
            {
                if (_driver != null)
                {
                    _driver.Quit();
                    _driver = null;
                }
            }
            [Test]
            public void VerifySHOPNOWButtonDisplayed()
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.FindElementByName("SHOP NOW").Displayed);
            }
            
        }
    }
}