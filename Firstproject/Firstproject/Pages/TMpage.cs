using Firstproject.Utilities;
using OpenQA.Selenium;
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

            //Select time from dropdown list
            IWebElement typeCodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodedropdown.Click();

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

            //Check if new time record has been created successfully

            //Navigate to the last page

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);

            IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastPageButton.Click();
            Thread.Sleep(2000);

            //Check if record is present in the table
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "May")
            {
                Console.WriteLine("Newrecord has been created");
            }
            else
            {
                Console.WriteLine("Newrecord has not created");
            }
        }

        public void EditTM(IWebDriver driver)
        {

            //Edit the record
            IWebElement lastRecordEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            lastRecordEditButton.Click();
            Thread.Sleep(2000);

            //Select material from dropdown list
            IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            Typecodedropdown.Click();
            IWebElement MaterialOPtion = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            MaterialOPtion.Click();

            //Edit input code
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("May22new");

            //Edit input description
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("des");

            //Edit input price(Overlap Textbox)
            IWebElement editPriceTextboxOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPriceTextboxOverlap.Click();
            editPrice.Clear();
            editPriceTextboxOverlap.Click();
            editPrice.SendKeys("99");
            Thread.Sleep(3000);

            //save edited record
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //Navigate to the last page
            IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastPageButton.Click();
            Thread.Sleep(2000);

            //Check if edit record present in the table
            IWebElement Updatedcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (Updatedcode.Text == "May22new")
            {
                Console.WriteLine("Record has updated in code successfully");
            }
            else
            {
                Console.WriteLine("Record has not updated successfully");
            }
        }

        public void DeleteTM(IWebDriver driver)
        {
            //Click Delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(2000);

            //Check if lastrecord deleted
            IWebElement lastRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastRecordCode.Text != "May22new")
            {
                Console.WriteLine("Record deleted successfully");
            }
            else
            {
                Console.WriteLine("Record has not deleted");
            }



        }
    }
}
    

