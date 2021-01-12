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
using Xunit;

namespace TestProjectSelenium.Tests.Steps
{
    [Binding]
    class PagesPageSteps : TechTalk.SpecFlow.Steps
    {
        private readonly RemoteWebDriver _driver;
        private readonly UserDto _user;

        public PagesPageSteps(RemoteWebDriver driver, UserDto user)
        {
            _driver = driver;
            _user = user;
        }

        [StepDefinition(@"I navigate to Pages List")]
        public void NavigateToPagesList()
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                pagesPage.PagesNav.JsHighlight().JsClick();
                pagesPage.PagesListSubNav.JsHighlight().JsClick();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I click on Edit Page button")]
        public void ClickOnEditPageButton()
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                pagesPage.EditPageButton.JsHighlight().Click();
            }
            _driver.RetryInCaseOfException(Action);
        }


        [StepDefinition(@"I navigate to Modules nav tab")]
        public void NavigateToModulesNavTab()
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                pagesPage.ModulesTab.JsHighlight().Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I click on Save button")]
        public void ClickOnSaveButton()
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                pagesPage.SaveButton.JsHighlight().Click();
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I turned '(.*)' checkbox off")]
        public void CheckedLeaderboardCheckboxOff(string id)
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                if (pagesPage.GetCheckBoxById(id).Selected)
                {
                    pagesPage.GetCheckBoxByFor(id).JsHighlight().Click();
                }
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"I turned '(.*)' checkbox on")]
        public void CheckedLeaderboardCheckboxOn(string id)
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                if (!pagesPage.GetCheckBoxById(id).Selected)
                {
                    pagesPage.GetCheckBoxByFor(id).JsHighlight().Click();
                }
            }
            _driver.RetryInCaseOfException(Action);
        }

        [StepDefinition(@"'(.*)' page displayed")]
        public void PageDisplayed(string pageName)
        {
            var stagePage = _driver.NowAt<PagesPage>();

            _driver.RetryInCaseOfException(() => Assert.True(stagePage.GetPageByName(pageName).Displayed));
        }

        [StepDefinition(@"'(.*)' category displayed")]
        public void ThenCategoryDisplayed(string categoryName)
        {
            var stagePage = _driver.NowAt<PagesPage>();

            _driver.RetryInCaseOfException(() => Assert.True(stagePage.GetCategoryByName(categoryName).Displayed));
        }


        [StepDefinition(@"I delete '(.*)' page created before")]
        public void DeletePageCreatedBefore(string pageName)
        {
            var pagesPage = _driver.NowAt<PagesPage>();

            void Action()
            {
                    pagesPage.GetDeleteButtonByPageName(pageName).JsHighlight().Click();
                    _driver.SwitchTo().Alert().Accept();
            }
            _driver.RetryInCaseOfException(Action);
        }

    }
}
