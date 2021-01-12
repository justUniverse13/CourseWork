using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSelenium.Code.Base;

namespace TestProjectSelenium.Tests.Pages
{
    class PagesPage : SeleniumBasePage
    {
        public IWebElement PagesNav => Driver.FindElement(By.XPath("//aside/div/nav/ul/li[3]/a/span"));
        public IWebElement PagesListSubNav => Driver.FindElement(By.XPath("//aside/div/nav/ul/li[3]/ul/li[1]/a/span"));

        public IWebElement EditPageButton => Driver.FindElement(By.XPath("//*[@id='5f228bcf6a2a3138c948fa2b']/td/a[@title='Edit']"));

        public IWebElement ModulesTab => Driver.FindElement(By.XPath("//a[@role='tab'][contains(text(),'Modules')]"));

        public IWebElement SaveButton => Driver.FindElement(By.XPath("//*[@class='btn save-button btn-primary']"));

        public IWebElement GetCheckBoxByFor(string _for)
        {
            return Driver.FindElement(By.XPath($"//*[@for='{_for}']"));
        }

        public IWebElement GetPageByName(string pageName)
        {
            return Driver.FindElement(By.XPath($"//td[contains(text(),'{pageName}')]"));
        }

        public IWebElement GetCategoryByName(string categoryName)
        {
            return Driver.FindElement(By.XPath($"//td[contains(text(),'{categoryName}')]"));
        }

        public IWebElement GetCheckBoxById(string id)
        {
            return Driver.FindElement(By.XPath($"//*[@id='{id}']"));
        }

        public IWebElement GetDeleteButtonByPageName(string pageName)
        {
            return Driver.FindElement(By.XPath($"//td[contains(text(),'{pageName}')]/parent::tr/td/button[@title='Remove Page']"));
        }
    }
}
