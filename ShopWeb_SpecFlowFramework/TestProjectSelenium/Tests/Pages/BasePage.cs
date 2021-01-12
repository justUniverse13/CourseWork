
using OpenQA.Selenium;
using TestProjectSelenium.Code.Base;

namespace TestProjectSelenium.Tests.Pages
{
   public class BasePage : SeleniumBasePage
    {
        public IWebElement ShoesItem => Driver.FindElement(By.XPath("//*[@class='col-lg-4']"));

        public IWebElement EndShoppingRequestButton => Driver.FindElement(By.XPath("//*[@class='btn btn-success']"));
        public IWebElement Toggle => Driver.FindElement(By.XPath("//*[@class='ball']"));
        public IWebElement ShoesCartItem => Driver.FindElement(By.XPath("//*[@class='alert alert-warning mt-3']"));
        public IWebElement AddToTheCartButton => Driver.FindElement(By.XPath("//*[@class='btn btn-warning']"));

        public IWebElement GetItemByPlaceholder(string placeholder)
        {
            return Driver.FindElement(By.XPath($"//*[@placeholder='{placeholder}']"));
        }

        public IWebElement GetItemByName(string Name)
        {
            return Driver.FindElement(By.XPath($"//*[@name='{Name}']"));
        }

        public IWebElement GetTextLocatorByText(string text)
        {
            return Driver.FindElement(By.XPath($"//*[text()='{text}']"));
        }

        public IWebElement GetButtonByText(string text)
        {
            return Driver.FindElement(By.XPath($"//*[text()='{text}']"));
        }

        public IWebElement GetNavBarByName(string navBarName)
        {
            return Driver.FindElement(By.XPath($"//*[@class='nav-link'][contains(text(),'{navBarName}')]"));
        }
    }
}
