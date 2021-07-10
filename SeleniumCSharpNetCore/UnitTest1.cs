using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.IO;
using System.Reflection;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        LandingPage landingPage = new LandingPage();
        Registration registrationPage = new Registration();
        FindoutMore findoutmore = new FindoutMore();

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(option);
            Driver.Navigate().GoToUrl("https://ensekautomationcandidatetest.azurewebsites.net/Account/Register/");
        }
        
        public void navigateToRegistrationPage()
        {  
            landingPage.clickRegister();
         }
        public void navigateToFindOutMorePage()
        {
            landingPage.clickFindOutMore();
        }

        [Test]
        public void VerifyRegistrationFormFieldsandFooter()
        {
            navigateToRegistrationPage();
            Assert.That(registrationPage.IsEmailTextBoxExists(), Is.True, "Email Text Box present");
            Assert.That(registrationPage.IsPasswordTextBoxExists(), Is.True, "Password Text Box present");
            Assert.That(registrationPage.IsEmailFieldExists(), Is.True, "Confirm Password Text Box present");
            Assert.That(registrationPage.ValidatetxtFooter().Contains("[For Candidate Testing Purposes Only]"));
        }
        [Test]
        public void FindOutMorePageValidations()
        {
           Assert.That(findoutmore.getPageTitle().Contains("ENSEK: Enable Better - Leading Software for the Energy Sector"));
        }

    }
}
