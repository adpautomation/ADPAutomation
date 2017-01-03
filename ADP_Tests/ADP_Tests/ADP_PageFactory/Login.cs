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
        }

        public void LoginToMobile()
        {
            UserName.Clear();
            UserName.SendKeys(SmokeTestWindow.username);
            Password.Clear();
            Password.SendKeys(SmokeTestWindow.password);
   //         Logger.screenshot_PASS("Given valid user creddentials");
            click(login_button);
        }
    }
}



