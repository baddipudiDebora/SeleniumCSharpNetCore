using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{

    [Binding]
    public class Steps
    {
        Tests test = new Tests();

        [Given(@"I navigate to application landing page")]
        public void GivenINavigateToApplicationLandingPage()
        {
            test.Setup();
        }

        [When(@"I click on Register link")]
        public void WhenIClickOnRegisterLink()
        {
            test.navigateToRegistrationPage();
        }

        [Then(@"I validate the form fields and Footer Text")]
        public void ThenIValidateTheFormFields()
        {
            test.VerifyRegistrationFormFieldsandFooter();
        }
        [When(@"I click on FindoutMore link")]
        public void WhenIClickOnFindoutMoreLink()
        {
            test.navigateToFindOutMorePage();
        }
        [Then(@"I validate the page title")]
        public void ThenIValidateThePageTitle()
        {
            test.FindOutMorePageValidations();
        }


    }
}
