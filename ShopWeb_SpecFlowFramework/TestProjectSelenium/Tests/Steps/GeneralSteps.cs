using AngleSharp.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;
using TestProjectSelenium.Code.Base;
using TestProjectSelenium.Code.Dto;
using TestProjectSelenium.Code.Extensions;
using TestProjectSelenium.Code.Providers;
using TestProjectSelenium.Tests.Pages;

namespace TestProjectSelenium.Tests.Steps
{
    [Binding]
    public class GeneralSteps : TechTalk.SpecFlow.Steps
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public GeneralSteps(RemoteWebDriver driver, UserDto user)
        {
            _driver = driver;
            _user = user;
        }


        [StepDefinition(@"I open In EZShoes page")]
        public void WhenIOpenInTheGamePage()
        {
            _driver.Navigate().GoToUrl(UrlProvider.StartUrl);
        }

      

        [StepDefinition(@"I open player page")]
        public void WhenIOpenPlayerPage()
        {
            _driver.Navigate().GoToUrl("https://eager-saha-dab421.netlify.app/");
            _driver.WaitForDataLoading();
        }

        [StepDefinition(@"url contains '(.*)'")]
        public void UrlContains(string url)
        {
            Assert.IsTrue(_driver.Url.Contains(url));
        }

    }
}
