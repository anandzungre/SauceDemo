using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PageObectModel
{
    public class BasePage
    {
        public static IWebDriver driver;

        public void SeleniumInit(string browser)
        {           
            switch (browser)
            {
                case "chrome":
                    var chrome = new ChromeDriver();
                    driver = chrome;
                    break;
                case "Firefox":
                    var firefox = new ChromeDriver();
                    driver = firefox;
                    break;
                default:
                    var defaultchrome = new ChromeDriver();
                    driver = defaultchrome;
                    break;
            }
            driver.Url = "https://www.saucedemo.com/";
        }
    }
}
