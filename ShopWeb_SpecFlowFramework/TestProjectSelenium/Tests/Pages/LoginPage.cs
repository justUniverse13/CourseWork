using OpenQA.Selenium;
using System.Collections.Generic;
using TestProjectSelenium.Code.Base;

namespace TestProjectSelenium.Tests.Pages
{
    public class LoginPage : SeleniumBasePage
    {
        public IWebElement Username => Driver.FindElement(By.XPath("//*[@id='username']"));
        public IWebElement Password => Driver.FindElement(By.XPath("//*[@id='password']"));

        public IWebElement SignInButton => Driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-lg btn-block']"));
    }
}