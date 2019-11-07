using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace AutoTest
{
public class ManageBrowserWindow{
    IWebDriver driver = new ChromeDriver("F:\\AutoTest\\bin\\Debug\\netcoreapp2.1");
   [Fact]
   public void ManageWindow()
   {
   driver.Manage().Window.FullScreen();
   Thread.Sleep(5000);
   driver.Quit();



   
   
   
   } 
}

}