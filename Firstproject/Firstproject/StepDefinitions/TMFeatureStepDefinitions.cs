using Firstproject.Pages;
using Firstproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Firstproject.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
            
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTime(driver);
           
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMpage tmPageObj = new TMpage();
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.AreEqual( "May",newCode, "Actual code and expected code do not match");
            Assert.AreEqual("MayUpdate",newDescription , "Actual description and expected description do not match");
            Assert.AreEqual("$100.00",newPrice , "Actual price and expected price do not match");

        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string code, string description, string price)
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTM(driver, code, description, price);
        }

        [Then(@"The record should be updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string code, string description, string price)
        {
            TMpage tmPageObj = new TMpage();
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            Assert.AreEqual(code, editedCode, "Actual edited code and expected code do not match");
            Assert.AreEqual(description, editedDescription, "Actual edited description and expected description do not match");
            Assert.AreEqual(price, editedPrice, "Actual edited price and expected price do not match");
        }

        [When(@"I delete '([^']*)','([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIDeleteAndOnAnExistingTimeAndMaterialRecord(string code, string description, string price)
        {
            TMpage tmPageObj = new TMpage();
            tmPageObj.DeleteTM(driver, code, description, price);
        }

        [Then(@"The record should be deleted '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeDeletedAnd(string code, string description, string price)
        {
            TMpage tmPageObj = new TMpage();
            string deletedCode = tmPageObj.GetDeletedCode(driver);
            string deletedDescription = tmPageObj.GetDeletedDescription(driver);
            string deletedPrice = tmPageObj.GetDeletedPrice(driver);

            Assert.AreNotEqual(code, deletedCode, "Actual edited code and expected code do not match");
            Assert.AreNotEqual(description, deletedDescription, "Actual edited description and expected description do not match");
            Assert.AreNotEqual(price, deletedPrice, "Actual edited price and expected price do not match");
        }


    }
}
