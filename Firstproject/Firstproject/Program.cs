using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        Thread.Sleep(2000);
        //Click remember me
       // IWebElement RemembermeButton = driver.FindElement(By.Id("RememberMe"));
        //RemembermeButton.Click();
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
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTab.Click();
        IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmOption.Click();
        IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        CreateNewButton.Click();
        IWebElement TypeCodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        TypeCodedropdown.Click();
        IWebElement TimeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        TimeOption.Click();
        IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
        CodeTextbox.SendKeys("first");
        IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
        DescriptionTextbox.SendKeys("fff");
        IWebElement PriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        PriceTextbox.SendKeys("44");
        IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
        SaveButton.Click();
        Thread.Sleep(3000);
        IWebElement GotolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        GotolastPageButton.Click();
        IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        if (Newcode.Text == "first")
        {
            Console.WriteLine("Newrecord has created");
        }
        else
        {
            Console.WriteLine("Newrecord has not created");
        }


    }


}