using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest{
 public class webelements{
IWebDriver driver = new ChromeDriver("F:\\AutoTest\\bin\\Debug\\netcoreapp2.1");
[Fact]
public void Captureerror()
{
driver.Navigate().GoToUrl("https://techbroz.co.nz/my-account-2/");
driver.FindElement(By.Name("username")).SendKeys("shalanhc@gmail.com");
driver.FindElement(By.Id("password")).SendKeys("Abcde@123");
driver.FindElement(By.XPath("/*[@id='customer_login']/div[1]/form/p[4]/label/span")).Click();
driver.FindElement(By.Name("login")).Click();
IWebElement element = driver.FindElement(By.XPath("//*[@id='post-3854']/div/div/div/div[1]/ul/li"));

}
 }  

}