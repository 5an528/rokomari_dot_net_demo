using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Rokomari.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Rokomari.Pages
{
    public class BaseClass
    {
        public static IWebDriver _driver = new ChromeDriver();

        public ExtentReports _extent;
        public ExtentTest _test;


        [SetUp]
        public void setUp()
        {
            _driver.Navigate().GoToUrl(Locators.homePageUrl);
            _driver.Manage().Window.Maximize();
            Thread.Sleep(Locators.timeCount);
        }

        [OneTimeTearDown]
        protected void ExtentClose()
        {
            Console.WriteLine("OneTimeTearDown");
            _extent.Flush();

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(Locators.timeCount);

            _driver.Quit();

        }

    }
}
