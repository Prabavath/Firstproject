using Firstproject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser
        IWebDriver driver = new ChromeDriver();

        //LoginPage Object initialization and calling method
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginSteps(driver);

        //HomePage Object initialization and calling method
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TMPage Object initialization and calling method
        TMpage tmPageObj = new TMpage();
        tmPageObj.CreateTime(driver);

        //EditTM Record
        TMpage editObj = new TMpage();
        editObj.EditTM(driver);

        //DeleteTM Record
        TMpage deleteObj = new TMpage();
        deleteObj.DeleteTM(driver);


    }
}