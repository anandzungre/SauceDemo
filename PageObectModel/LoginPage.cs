using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObectModel
{
    public class LoginPage : BasePage
    {
        public void Login(string username, string password)
        {
            By Username = By.Id("user-name");
            By Password = By.Id("password");
            By Login = By.Id("login-button");

            driver.Manage().Window.Maximize();           
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(Login).Click();
            try
            {
                Thread.Sleep(1000);
                string Url = driver.Url;
                Assert.AreEqual(Url, "https://www.saucedemo.com/inventory.html");
            }
            finally
            {
                Thread.Sleep(1000);
            }           

        }
    }
}
