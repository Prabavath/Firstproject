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
        //Homepage and employeepage object initialization
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();
         
        [Test, Order(1)]

        public void CreateEmployee_Test()
        {
            // Create employee record calling method
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmp(driver);

        }

        [Test, Order(2)]

        public void EditEmployee_Test()
        {
            //Edit employee record calling method
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmp(driver);

        }

        [Test,Order(3)]

        public void DeleteEmployee_Test()
        {
            //Delete employee record calling method
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmp(driver);
        }

    }
}
