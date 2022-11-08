using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Lab_2;
using SpecFlowProject1.StepDefinitions;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions:BaseSteps
    {
        private OpenAccountPage openAccountPage;

        [Given(@"XYZ Bank page")]
        public void GivenXYZBankPage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject";
            openAccountPage = new OpenAccountPage(driver);
        }

        [When(@"click Bank Manager Login, click Open Account, choose Customer name Hermoine Granger, choose Currency Rupee, click Process")]
        public void WhenClickBankManagerLoginClickOpenAccountChooseCustomerNameHermoineGrangerChooseCurrencyRupeeClickProcess()
        {
            openAccountPage.OpenANewAccount();
        }

        [Then(@"Success alert should appear")]
        public void ThenSuccessAlertShouldAppear()
        {
            openAccountPage.CheckThatAlertContainsText("Account created successfully");
        }
    }
}