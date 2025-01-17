﻿using System;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProjectSelenium.Code.Utils
{
    // TODO remove after all tests are fixed
    public class ByFactory
    {
        public static By From(FindsByAttribute attribute)
        {
            How how = attribute.How;
            string @using = attribute.Using;
            switch (how)
            {
                case How.Id:
                    return By.Id(@using);

                case How.Name:
                    return By.Name(@using);

                case How.TagName:
                    return By.TagName(@using);

                case How.ClassName:
                    return By.ClassName(@using);

                case How.CssSelector:
                    return By.CssSelector(@using);

                case How.LinkText:
                    return By.LinkText(@using);

                case How.PartialLinkText:
                    return By.PartialLinkText(@using);

                case How.XPath:
                    return By.XPath(@using);
            }
            throw new ArgumentException(string
                .Format(CultureInfo.InvariantCulture, "Did not know how to construct How from how {0}, using {1}",
                new object[] { how, @using }));
        }
    }
}
