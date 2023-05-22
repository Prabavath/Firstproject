using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        //opn chrome user
        IWebDriver driver = new ChromeDriver();
        //launch turnup portal
        driver.Navigate().GoToUrl(" http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();
        //identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");
        //identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");
        //click login button
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        //check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully");
        }
        else
        {
            Console.WriteLine("User has not logged in ");
        }

        // Create new record
        //Navigate time and Material page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();
        IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmOption.Click();
        //Click on create new button
        IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        CreateNewButton.Click();
        //Select time from dropdown list
        IWebElement TypeCodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        TypeCodedropdown.Click();
        IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        TimeOption.Click();
        //Input Code
        IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
        CodeTextbox.SendKeys("May");
        IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
        DescriptionTextbox.SendKeys("MayUpdate");
        IWebElement PriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        PriceTextbox.SendKeys("100");
        IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
        SaveButton.Click();
        Thread.Sleep(3000);

        //Check if new time record has been created successfully
        //Navigate to the last page
        IWebElement GotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        GotolastPageButton.Click();
        Thread.Sleep(2000);
        //Check if record is present in the table
        IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[1]"));
        if (Newcode.Text ==  "May")
        {
            Console.WriteLine("Newrecord has been created");
        }
        else
        {
            Console.WriteLine("Newrecord has not created");
        }

        //Click Edit Button
        IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
        EditButton.Click();
        //Select material from dropdown list
        IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        Typecodedropdown.Click();
        IWebElement MaterialOPtion = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        MaterialOPtion.Click();
        //Edit input code
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.Clear();
        codeTextbox.SendKeys("May22new");
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Console.WriteLine("Editing a record successful");
        Thread.Sleep(3000);
        //Navigate to the last page
        IWebElement gotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        gotolastPageButton.Click();
        Thread.Sleep(2000);
        //Check if edit record present in the table
        IWebElement Updatedcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));
        if (Updatedcode.Text == "May22new")
        {
            Console.WriteLine("Record has updated in code successfully");
        }
        else
        {
            Console.WriteLine("Record has not updated successfully");
        }

        //Click Delete record
        IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
        DeleteButton.Click();
        Thread.Sleep(2000);
        driver.SwitchTo().Alert().Accept();
        IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        gotoLastPageButton.Click();
        Thread.Sleep(2000);
        Console.WriteLine("Record has been deleted");
       
      












    }


}