using AventStack.ExtentReports;
using Rokomari.Pages;
using Rokomari.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Rokomari.Pages.PageObjects;

namespace Rokomari.Tests
{
    [TestFixture]
    public class HomeElementsTests : BaseClass
    {
        HomePage homePage = new HomePage(_driver);

        [Test]
        public void test1()
        {
            Thread.Sleep(Locators.timeCount);
            homePage.CloseAdBtn();

            Thread.Sleep(Locators.timeCount);
            homePage.SignUpBtn();
            Thread.Sleep(Locators.timeCount);
            homePage.SendUserName();
            Thread.Sleep(Locators.timeCount);
            homePage.SendPassword();
            Thread.Sleep(Locators.timeCount);
            homePage.ClickOnSignInFinalBtn();
            Thread.Sleep(Locators.timeCount);
            homePage.ElectronicsBtn();
        }
    }
}
