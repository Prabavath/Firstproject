using Firstproject.Utilities;
using NuGet.Frameworks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstproject.Pages
{
    public class EmployeePage : CommonDriver
    {
        public void CreateEmp(IWebDriver driver)
        {
            //Click on create button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //Input name
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Tim");
            Thread.Sleep(2000);

            //Input username
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("Tom");

            //Input contact

            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("1234567");
            Thread.Sleep(2000);

            //click on editcontact button
            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector("iframe[title='Edit Contact']")));

            //Inputname in editcontact window
            IWebElement firstnameTextbox = driver.FindElement(By.Id("FirstName"));
            firstnameTextbox.SendKeys("Tim");
            IWebElement lastnameTextbox = driver.FindElement(By.Id("LastName"));
            lastnameTextbox.SendKeys("Tom");
            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.Click();
            phoneTextbox.SendKeys("1234567");

            //click on save button
            IWebElement saveContactTextbox = driver.FindElement(By.Id("submitButton"));
            saveContactTextbox.Click();

            //Input password 
            driver.SwitchTo().DefaultContent();
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("TimTom123!");

            //Input Retypepassword
            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("TimTom123!");

            //Check admin
            IWebElement adminButton = driver.FindElement(By.Id("IsAdmin"));
            adminButton.Click();

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //click back to list
            IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolistButton.Click();
            Thread.Sleep(2000);

            //click on Gotolastpage button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(2000);

            //check record present in the table
            IWebElement nameText = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(nameText.Text == "Tim", "Actual name and expected name do not match");
           /* if(nameText.Text == "Tim")
            {
                Assert.Pass("Employee record has created successfully");

            }
            else
            {
                Assert.Fail("Employee record has not created");
            }*/

        }

        public void EditEmp(IWebDriver driver)
        {

            //Navigate to the last page
            Thread.Sleep(2000);
            IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotolastPageButton.Click();


            //Check if last record present in the table                  
            IWebElement lastName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastName.Text == "Tim")                        
            {
                Thread.Sleep(2000);
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editButton.Click();                                  
                Thread.Sleep(3000);
            }
            else
            {

                Assert.Fail("New record created has not been found");

            }
           
            //Edit input name
            IWebElement editNameTextbox = driver.FindElement(By.Id("Name"));
            editNameTextbox.Clear();
            editNameTextbox.SendKeys("Amal");

            //Edit input username
            IWebElement editUsernameTextbox = driver.FindElement(By.Id("Username"));
            editUsernameTextbox.Clear();
            editUsernameTextbox.SendKeys("Pal");

            //save edited record
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

  

        }

        public void DeleteEmp(IWebDriver driver)
        {
            //goto lastpage  
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(2000);

            //Click lastpage Delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();                                  

            //To click an alert window
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            //Check if lastrecord deleted
            IWebElement lastRecordName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastRecordName.Text != "Amal", "Record has not been deleted");



        }
    }
}



            

            
            

            
       








            

            


           

    

