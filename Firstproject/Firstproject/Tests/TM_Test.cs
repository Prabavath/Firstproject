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
    [Parallelizable]

    public class TM_Test : CommonDriver
    {   //Homepage and TMpage object initialization
        HomePage homePageObj = new HomePage();
        TMpage tmPageObj = new TMpage();
     
        
        [Test, Order(1)]
        public void CreateTime_Test()
        {
            //CreateTM record calling method
            homePageObj.GoToTMPage(driver); 
            tmPageObj.CreateTime(driver);
        }

        [Test, Order(2)]
        public void EditTM_Test()
        {
            //EditTM record calling method
            homePageObj.GoToTMPage(driver);
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3)]
        public void DeleteTM_Test()
        {
            //DeleteTM record calling method
            homePageObj.GoToTMPage(driver);
            tmPageObj.DeleteTM(driver);

        }

               
    }
}
