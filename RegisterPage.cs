using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace AutoTest{
public class Registerpage{
    IWebDriver driver = new ChromeDriver("F:\\AutoTest\\bin\\Debug\\netcoreapp2.1");
[Fact]
public void TestName()
{
    driver.Navigate().GoToUrl("https://techbroz.co.nz/my-account-2/");
    driver.Manage().Window.Maximize();
driver.FindElement(By.Id("reg_billing_first_name")).SendKeys("Abcde1");
driver.FindElement(By.Id("reg_billing_last_name")).SendKeys("Xyzerf");
driver.FindElement(By.Id("reg_billing_phone")).SendKeys("02024882889");
driver.FindElement(By.Id("reg_email")).SendKeys("xyzshc2011@gmail.com");
driver.FindElement(By.Id("reg_password")).SendKeys("Abcde@123");
driver.FindElement(By.Name("register")).Click();
Assert.True(driver.FindElement(By.LinkText("Log out")).Displayed);

driver.Quit();
}

}

}