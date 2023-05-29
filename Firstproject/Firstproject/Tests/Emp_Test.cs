using Firstproject.Pages;
using Firstproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstproject.Tests
{
    [TestFixture]
    [Parallelizable]

    public class Emp_Test : CommonDriver
    {
        [SetUp]

        public void setUpactions()
        {
            //Open chrome browser
            driver = new ChromeDriver();

            //Loginpage object initialization and calling method
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //Homepage initialization and calling method
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }

        [Test, Order(1)]

        public void CreateEmployee_Test()
        {
            // createemployee object initialization and calling method
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmp(driver);

        }

        [Test, Order(2)]

        public void EditEmployee_Test()
        {
            //Editemployee  object initialization and calling method
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmp(driver);

        }

        [Test,Order(3)]

        public void DeleteEmployee_Test()
        {
            //Delete employee object initialization and calling method
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmp(driver);
        }

        [TearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
