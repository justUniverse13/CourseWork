using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using BoDi;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;
using TestProjectSelenium.Code.Extensions;
using TestProjectSelenium.Code.Providers;
using TestProjectSelenium.Code.Utils;
using Xunit.Abstractions;

namespace TestProjectSelenium.Code.Base
{
    [Binding]
    class BeforeAfterActions : BaseTest
    {
        private readonly IObjectContainer _objectContainer;

        public BeforeAfterActions(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void OnStartUp()
        {
            var driverInstance = CreateBrowserDriver();

            #region Set Browser size

            var browserSize = ConfigurationManager.AppSettings["browserSize"];

            switch (browserSize)
            {
                case "Default":
                    break;
                case "FullScreen":
                    driverInstance.Manage().Window.Maximize();
                    break;
                default:
                    {
                        if (browserSize.Contains(','))
                            driverInstance.Manage().Window.Size = new Size(int.Parse(browserSize.Split(',')[0]), int.Parse(browserSize.Split(',')[1]));
                        else
                            throw new Exception($"Browser window size can't be set. Unknown settings: '{browserSize}'");
                    }
                    break;
            }

            #endregion

            _objectContainer.RegisterInstanceAs<RemoteWebDriver>(driverInstance);


        }



        [AfterScenario]
        public void OnTearDown()
        {
            try
            {
                var driver = _objectContainer.Resolve<RemoteWebDriver>();

                //TODO implement suitable screenshots naming
                BrowserScreenshot.Get(driver, GetType().Name);

                Logger.Write($"Closing window at: {driver.Url}");

                driver.QuitDriver();
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }

        [AfterStep]
        public void AfterEachStep()
        {
            var driver = _objectContainer.Resolve<RemoteWebDriver>();

            driver.WaitForDataLoading();
        }
        /*

        */


    }
}

