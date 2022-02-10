using Rokomari.Tests;
using Rokomari.Utils;
using Rokomari.Utils.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Rokomari.Pages.PageObjects
{
    public class HomePage
    {
        String homePageUrl = Locators.homePageUrl;

        private IWebDriver __driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver __driver)
        {
            this.__driver = __driver;
            wait = new WebDriverWait(__driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(__driver, this);
        }

        //Ad Close Button
        [FindsBy(How = How.XPath, Using = "html/body/div[3]/div[1]/button")]
        private IWebElement closeadBtn;

        public void CloseAdBtn() => closeadBtn.Click();

        //Sign Up Button
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/div/div[3]/div/div[2]/a")]
        private IWebElement signupBtn;

        //Sign in Page
        public void SignUpBtn() => signupBtn.Click();

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section/div[2]/div[2]/form/div[1]/div/input")]
        [CacheLookup]
        private IWebElement userName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section/div[2]/div[2]/form/div[2]/div/input")]
        [CacheLookup]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/section/div[2]/div[2]/form/button")]
        [CacheLookup]
        private IWebElement signInFinalBtn;

        //Signing Progression
        public void SendUserName() => userName.SendKeys("01888018837");

        public void SendPassword() => password.SendKeys("lolme1011");

        public void ClickOnSignInFinalBtn() => signInFinalBtn.Click();

        //Electronics Button
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/nav/div/div[1]/ul/li[2]/a")]
        private IWebElement electronicsBtn;

        public void ElectronicsBtn() => electronicsBtn.Click();

    }

}
