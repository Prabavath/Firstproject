using Firstproject.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firstproject.Utilities;
using NUnit.Framework;

namespace Firstproject.Tests
{
    [TestFixture]

    public class TM_Test : CommonDriver
    {
        [SetUp]

        public void SetUpActions()
        {
            //open chrome browser
            driver = new ChromeDriver();

            //LoginPage Object initialization and calling method
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //HomePage Object initialization and calling method
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test, Order(1)]
        

        public void CreateTime_Test()
        {
            //TMPage Object initialization and calling method
            TMpage tmPageObj = new TMpage();
            tmPageObj.CreateTime(driver);
        }

        [Test, Order(2)]

        public void EditTM_Test()
        {
            //EditTM Record
            TMpage tmPageObj = new TMpage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3)]

        public void DeleteTM_Test()
        {
            //DeleteTM Record
            TMpage tmPageObj = new TMpage();
            tmPageObj.DeleteTM(driver);

        }

        [TearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }

         
    }
}
