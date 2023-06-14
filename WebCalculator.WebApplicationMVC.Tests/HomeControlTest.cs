using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WebCalculator.WebApplicationMVC.Tests;

[TestClass]
public class HomeControlTest
{
    private IWebDriver _driver;
    
    [TestInitialize]
    public void SetUp()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver();
    }
    
    [TestMethod]
    public void TitleShouldHaveHomeInIt()
    {
        _driver.Navigate().GoToUrl("https://localhost:7088");
        Assert.IsTrue(_driver?.Title.Contains("Home"));
    }
    
    [TestCleanup]
    public void Teardown()
    {
        _driver.Close();
    }

    
}