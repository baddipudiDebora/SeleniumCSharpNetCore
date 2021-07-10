using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class Registration : DriverHelper
    {

        IWebElement txtBXBoxEmail => Driver.FindElement(By.Id("Email"));
        IWebElement txtBXBoxPassword => Driver.FindElement(By.Id("Password"));
        IWebElement txtBXConfirmpassword => Driver.FindElement(By.Id("ConfirmPassword"));

        IWebElement txtFooter => Driver.FindElement(By.TagName("footer"));
        public bool IsEmailTextBoxExists()
        {
            return txtBXBoxEmail.Displayed;
        }
        public bool IsPasswordTextBoxExists()
        {
            return txtBXBoxPassword.Displayed;
        }
        public bool IsEmailFieldExists()
        {
            return txtBXConfirmpassword.Displayed;
        }

        public string ValidatetxtFooter()
        {
            return txtFooter.GetAttribute("Text");
        }
    }
}
