using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
   

namespace AutoTest
{
    public class Class1
    {
        IWebDriver driver = new ChromeDriver ("F:\\AutoTest\\bin\\Debug\\netcoreapp2.1");
        [Fact]
                        public void TestName()
        {
        
        driver.Navigate().GoToUrl("https://techbroz.co.nz/");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Id("search")).SendKeys("Laptop");
        driver.FindElement(By.LinkText("My Account")).Click();
        driver.FindElement(By.Name("username")).SendKeys("shalanch@gmail.com");
        driver.FindElement(By.Id("password")).SendKeys("abcde123");
        driver.FindElement(By.Name("login")).Click();
                //Then
        Assert.True(true);
        driver.Quit();
        }
    }
}
