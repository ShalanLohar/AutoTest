using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace AutoTest{
public class LoginPage {

    IWebDriver driver = new ChromeDriver("F:\\AutoTest\\bin\\Debug\\netcoreapp2.1");
    [Fact]
    public void TestName()
    {
      driver.Navigate().GoToUrl("https://techbroz.co.nz/");
      driver.FindElement(By.LinkText("My Account")).Click();
      driver.FindElement(By.Name("username")).SendKeys("xyzedw@gmail.com");
      driver.FindElement(By.Id("password")).SendKeys("Abcde1234");
      driver.FindElement(By.Name("login")).Click();
      Assert.True(driver.FindElement(By.LinkText("Log out")).Displayed);

     driver.Quit();
      
    
    
    }
}

}