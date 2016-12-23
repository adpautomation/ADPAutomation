using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections;
using ADP_Tests;

namespace ADP_SeleniumFramework.ADP_PageFactory
{

    class Login: ADP_AbstractPageFactory
    {
        
        [FindsBy(How = How.Id, Using = "txUserName")]
        private IWebElement UserName;

        [FindsBy(How = How.Id, Using = "txPassword")]
        private IWebElement Password;

        [FindsBy(How = How.Id, Using = "bLogin")]
        private IWebElement login_button;


        public Login():base()
        {
            Logger.screenshot_PASS("Login page opens successully");
        }

        public void BOB_LoginToMobile()
        {
            UserName.Clear();
            UserName.SendKeys(BOB_SmokeTestWindow.username);
            Password.Clear();
            Password.SendKeys(BOB_SmokeTestWindow.password);
            Logger.screenshot_PASS("Account holder credentials are given");
            click(login_button);
            }

        public void BRET_LoginToMobile()
        {
            UserName.Clear();
            UserName.SendKeys(BRET_SmokeTestWindow.username);
            Password.Clear();
            Password.SendKeys(BRET_SmokeTestWindow.password);
  //          Logger.screenshot_PASS("Account holder credentials are given");
            click(login_button);
        }
    }
}



