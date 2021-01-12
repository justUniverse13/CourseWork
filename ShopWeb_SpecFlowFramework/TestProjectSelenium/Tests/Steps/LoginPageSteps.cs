using OpenQA.Selenium.Remote;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectSelenium.Code.Dto;
using TestProjectSelenium.Code.Extensions;
using TestProjectSelenium.Code.Providers;
using TestProjectSelenium.Tests.Pages;
using Xunit;

namespace TestProjectSelenium.Tests.Steps
{
    [Binding]
    class LoginPageSteps : TechTalk.SpecFlow.Steps
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public LoginPageSteps(RemoteWebDriver driver, UserDto user)
        {
            _driver = driver;
            _user = user;
        }

        [StepDefinition(@"I log in")]
        public void WhenILogIn()
        {
            var loginPage = _driver.NowAt<LoginPage>();

            void Action()
            {
                loginPage.SignInButton.JsHighlight().Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I input email")]
        public void WhenIInputEmail()
        {
            var loginPage = _driver.NowAt<LoginPage>();

            void Action()
            {
                loginPage.Username.JsHighlight().SendKeys(_user.Login);
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I input password")]
        public void WhenIInputPassword()
        {
            var loginPage = _driver.NowAt<LoginPage>();

            void Action()
            {
                loginPage.Password.JsHighlight().SendKeys(_user.Password);
            }
            _driver.RetryInCaseOfException(Action);
        }


    }
}