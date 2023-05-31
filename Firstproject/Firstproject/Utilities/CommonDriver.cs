using Firstproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstproject.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp ]
        public void LoginSteps()
        {
            //open chrome browser
            driver = new ChromeDriver();

            //LoginPage Object initialization and calling method
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();

        }
    }
}
