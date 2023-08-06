using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObectModel
{
    [TestClass]
    public class UnitTest1
    {
        LoginPage loginpage = new LoginPage();
        BasePage basepage = new BasePage();

        [TestInitialize]
        public void Initialize()
        {
            basepage.SeleniumInit("chrome");
        }

        [TestCleanup]
        public void CleanUp()
        {
            BasePage.driver.Close();
            BasePage.driver.Quit();
            BasePage.driver.Dispose();

        }

        [TestMethod]
        [DoNotParallelize]
        [TestCategory("Login"), TestCategory("FirstUserLogin")]
        [DataRow("standard_user", "secret_sauce")]
        public void TestMethod1(string username, string password)
        {

            loginpage.Login(username, password);

        }

        [TestMethod]
        [DoNotParallelize]
        [TestCategory("Login"), TestCategory("SecondUserLogin")]
        [DataRow("standard_user", "secret_sauce")]
        public void TestMethod2(string username, string password)
        {

            loginpage.Login(username, password);

        }

        [Ignore]
        [DoNotParallelize]
        [TestCategory("Login"), TestCategory("ThirdUserLogin")]
        [DataRow("standard_user", "secret_sauce")]
        public void TestMethod3(string username, string password)
        {

            loginpage.Login(username, password);

        }

        [TestMethod]
        [DoNotParallelize]
        [TestCategory("Login"), TestCategory("FourthUserLogin")]
        [DataRow("standard_user", "secret_sauce")]
        public void TestMethod4(string username, string password)
        {

            loginpage.Login(username, password);

        }

    }
}
