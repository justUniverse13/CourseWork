using System;
using System.Collections.Generic;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectSelenium.Code.Base
{
    class BaseTest
    {
        public RemoteWebDriver Driver { get; set; }

        public RemoteWebDriver CreateBrowserDriver()
        {
            var browserType = ConfigurationManager.AppSettings["targetBrowser"];

            switch (browserType)
            {
                case "Chrome":
                    //var map = new Map<string, string>();
                    //map.add("chrome.chromedriverVersion", "78.0.3904.108
                    //chromeOption.AddAdditionalCapability("chrome.prefs", prefs);
                    return new ChromeDriver();
                case "Firefox":
                    return new FirefoxDriver();
                case "InternetExplorer11":
                    return new InternetExplorerDriver();
                case "Edge":
                    return new EdgeDriver();
                case "Headless":
                    var driverService = ChromeDriverService.CreateDefaultService();
                    //var driverServices = new DriverManager().SetUpDriver(new ChromeDriver);
                    var chromeOptions = new ChromeOptions();
                    driverService.HideCommandPromptWindow = true;
                    chromeOptions.AddArgument("--headless");
                    chromeOptions.AddArgument("window-size=1024,768");
                    return Driver = new ChromeDriver(driverService, chromeOptions);
                    //return Driver = driverServices(chromeOptions);
                default:
                    throw new Exception($"Browser type '{browserType}' was not identified");
            }
        }
    }
}
