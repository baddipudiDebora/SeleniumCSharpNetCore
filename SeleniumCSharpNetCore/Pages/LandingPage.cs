using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LandingPage : DriverHelper
    {
        IWebElement lnkRegister => Driver.FindElement(By.Id("registerLink"));

        IWebElement lnkFindOutMore => Driver.FindElement(By.XPath("//a[@href='https://www.ensek.com']"));


        public void clickRegister()
        {
            lnkRegister.Click();
        }
      
        public void clickFindOutMore()
        {
            lnkFindOutMore.Click();
        }
    }
}
