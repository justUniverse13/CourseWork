using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProjectSelenium.Code.Dto;
using TestProjectSelenium.Code.Extensions;
using TestProjectSelenium.Tests.Pages;

namespace TestProjectSelenium.Tests.Steps
{
    [Binding]
    class BasePageSteps : TechTalk.SpecFlow.Steps
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public BasePageSteps(RemoteWebDriver driver, UserDto user)
        {
            _driver = driver;
            _user = user;
        }

        [StepDefinition(@"item with '(.*)' placeholder displayed")]
        public void WhenILogIn(string placeholder)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.GetItemByPlaceholder(placeholder).Displayed);
               
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"'(.*)' text displayed")]
        public void TextDisplayed(string text)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.GetTextLocatorByText(text).Displayed);

            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"'(.*)' nav bar displayed")]
        public void NavBarDisplayed(string navBarName)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.GetNavBarByName(navBarName).Displayed);

            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"Shoes items displayed")]
        public void ShoesItemsDisplayed()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.ShoesItem.Displayed);

            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I scoll to the bottom")]
        public void WhenIScollToTheBottom()
        {
            _driver.JsScrollToEnd();
        }

        [StepDefinition(@"I click on Add to the Cart button")]
        public void ThenIClickOnAddToTheCartButton()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
               basePage.AddToTheCartButton.Click();

            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"navigate to the '(.*)' nav bar")]
        public void ThenNavigateToTheNavBar(string navBarName)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                basePage.GetNavBarByName(navBarName).Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"shoes item displayed in ShopCart")]
        public void ThenShoesItemDisplayedInShopCart()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.ShoesCartItem.Displayed);
            }
            _driver.RetryInCaseOfException(Action);
        }


        [StepDefinition(@"I click on the toggle button")]
        public void IClickOnTheToggleButton()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                basePage.Toggle.Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"'(.*)' button displayed")]
        public void ThenButtonDisplayed(string buttonName)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                Assert.IsTrue(basePage.GetButtonByText(buttonName).Displayed);
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I click on Pay button")]
        public void ThenIClickOnPayButton()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                basePage.GetButtonByText("Pay").Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I input '(.*)' text to the '(.*)' placeholder")]
        public void ThenIInputTextToThePlaceholder(string text, string name)
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                basePage.GetItemByName(name).SendKeys(text);
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I click on End shopping request button")]
        public void ThenIClickOnEndShoppingRequestButton()
        {
            var basePage = _driver.NowAt<BasePage>();

            void Action()
            {
                basePage.EndShoppingRequestButton.Click();
            }
            _driver.RetryInCaseOfException(Action);
        }


    }
}
