using Firstproject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.HeapProfiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstproject.Pages
{
    public class TMpage 
    {
        public void CreateTime(IWebDriver driver)
        {

            //Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
          
            //Select time from typecode dropdown
            IWebElement typeCodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodedropdown.Click();
            Thread.Sleep(1000); 

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();
           
            //Input Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("May");

            //Input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("MayUpdate");

            //input price per unit
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("100");
            Thread.Sleep(2000);

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);

            //Check if new time record has been created successfully

            //Navigate to the last page

            IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastPageButton.Click();
            Thread.Sleep(2000);

            //Check if lastrecord is present on the table
                      
           
            //IWebElement newTypecodeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
                     
                                                                               
            //Assert.That(newCodeText.Text == "May", "Actual code and expected code do not match");
            //Assert.That(newTypecodeText.Text == "T", "Actual time and expected time do not match");
            //Assert.That(newDescriptionText.Text == "MayUpdate", "Actual description and expected description do not match");
            //Assert.That(newPriceText.Text == "$100.00", "Actual price and expected price do not match");
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }
        

        public void EditTM(IWebDriver driver,string code, string description, string price) 
        {

            //Navigate to the last page
            Thread.Sleep(2000);
            IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastPageButton.Click();

            Thread.Sleep(3000);

            /* Check if last record present in the table
             IWebElement lastElementCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
             if (lastElementCode.Text == "May")
             {
                 Thread.Sleep(2000);

             else
             {

                 Assert.Fail("New record created has not been found");

             }*/
            //Edit the record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);
        
            //Select material from dropdown list
            IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            Typecodedropdown.Click();
            IWebElement MaterialOPtion = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            MaterialOPtion.Click();

            //Edit input code
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys(code);

            //Edit input description
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys(description);

            //Edit input price(Overlap Textbox)
            IWebElement editPriceTextboxOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPriceTextboxOverlap.Click();
            editPrice.Clear();
            editPriceTextboxOverlap.Click();
            editPrice.SendKeys(price);
            Thread.Sleep(3000);

            //save edited record
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //chaeck if timerecord has been edited
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(2000);

            //find if record present on the page
           // IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Assert.That(editedCode.Text == "May22new", "Actual code and expected code not match");

        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement createdCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdCode.Text;
        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;
        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement createdPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return createdPrice.Text;
        }

        public void DeleteTM(IWebDriver driver, string code, string description, string price)
        {
            //goto lastpage  
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(2000);

            //Click lastpage Delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //To click an alert window
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
            //Check if lastrecord deleted
           public string GetDeletedCode(IWebDriver driver)
           {
            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return deletedCode.Text;
           }
        public string GetDeletedDescription(IWebDriver driver)
           {
            IWebElement deletedDescription = driver.FindElement(   By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return deletedDescription.Text;
           }
        public string GetDeletedPrice(IWebDriver driver)
           {
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return deletedPrice.Text;

           }
    }
}
    

